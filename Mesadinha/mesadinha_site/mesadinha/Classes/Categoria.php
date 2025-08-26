<?php
require_once "Conexao.php";

class Categoria
{
    public $id;
    public $nome;
    public $usuario_id;

    public function Alterar($id) {
        if (isset($_POST["name"]) && isset($_POST["enviar"])) {
            if (isset($_SESSION["usuario_id"])) {
                $this->id = $id;
                $this->nome = $_POST["name"];
                $this->usuario_id = $_SESSION["usuario_id"];

                try {
                    $bd = new Conexao();
                    $con = $bd->conectar();
                    $sql = $con->prepare("update categoria set nome = ? where id = ? and usuario_id = ?");
                    $sql->execute(array(
                        $this->nome,
                        $this->id,
                        $this->usuario_id,
                    ));

                } catch (PDOException $msg) {
                    echo "Erro ao alterar categoria: {$msg->getMessage()}";
                }
            }
        }
    }

    public function ObterNome($id) {
        try {
            if (isset($id)) {
                $bd = new Conexao();
                $con = $bd->conectar();
                $sql = $con->prepare("select nome from categoria where id = ? and categoria.usuario_id = ?");
                $sql->execute(array(
                    $id,
                    $_SESSION["usuario_id"]
                ));

                if ($sql->rowCount() == 0) {
                    return "Inexistente ou Inacessível";
                } else {
                    return $sql->fetchAll(PDO::FETCH_CLASS)[0]->nome;
                }

            } else {
                header("location: categorias.php");
            }
        } catch (PDOException $msg) {
            echo "Não foi possível excluir:" . $msg->getMessage();
        }
    }

    public function Excluir($id)
    {

        try {
            if (isset($id)) {
                $bd = new Conexao();
                $con = $bd->conectar();
                $sql = $con->prepare("delete from categoria where id = ? and usuario_id = ?");

                $sql->execute(array(
                    $id,
                    $_SESSION["usuario_id"]
                ));


            } else {
                header("location: categorias.php");
            }
        } catch (PDOException $msg) {
            echo "Não foi possível excluir:" . $msg->getMessage();
        }
    }

    public function Inserir()
    {
        if (isset($_POST["name"]) && isset($_POST["enviar"])) {
            if (isset($_SESSION["usuario_id"])) {
                $this->nome = $_POST["name"];
                $this->usuario_id = $_SESSION["usuario_id"];

                try {
                    $bd = new Conexao();
                    $con = $bd->conectar();
                    $sql = $con->prepare("insert into categoria(id, nome, usuario_id) values(null, ?, ?)");
                    $sql->execute(array(
                        $this->nome,
                        $this->usuario_id
                    ));
                } catch (PDOException $msg) {
                    echo "Erro ao inserir categoria: {$msg->getMessage()}";
                }
            }
        }
    }

    public function ListarTodos()
    {
        try {
            $bd = new Conexao();
            $con = $bd->conectar();
            $sql = $con->prepare("select distinct categoria.id as id, categoria.nome as nome, count(*) as contagem from categoria join conta on categoria.id = conta.categoria_id where categoria.usuario_id = ? group by categoria.id union select categoria.id as id, nome, null as contagem from categoria where categoria.usuario_id = ? and id != ALL(select categoria_id from conta where conta.categoria_id = categoria.id) order by id");
            $sql->execute(array(
                $_SESSION["usuario_id"],
                $_SESSION["usuario_id"]
            ));

            if ($sql->rowCount() > 0) {
                return $result = $sql->fetchAll(PDO::FETCH_CLASS);
            }
        } catch (PDOException $msg) {
            echo "Retorno com erro: {$msg}";
        }
    }
}