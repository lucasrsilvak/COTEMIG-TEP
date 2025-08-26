<?php
require_once "Conexao.php";

class Conta
{
    public $id;
    public $nome;
    public $tipo;
    public $categoria_id;

    public function Alterar($id)
    {
        if (isset($_POST["name"]) && isset($_POST["enviar"])) {
            if (isset($_SESSION["usuario_id"])) {
                $this->id = $id;
                $this->nome = $_POST["name"];
                $this->tipo = $_POST["tipo"] == "D" ? "D" : "R";
                $this->categoria_id = $_POST["categoria"];

                try {
                    $bd = new Conexao();
                    $con = $bd->conectar();
                    $sql = $con->prepare("update conta set nome = ?, tipo = ?, categoria_id = ? where conta.id = ? and ? = (select usuario_id from conta join categoria on conta.categoria_id = categoria.id where conta.id = ? and categoria.usuario_id = ?);");
                    $sql->execute(array(
                        $this->nome,
                        $this->tipo,
                        $this->categoria_id,
                        $id,
                        $_SESSION["usuario_id"],
                        $id,
                        $_SESSION["usuario_id"]
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
                $sql = $con->prepare("select nome from conta where id = ? and ? = (select usuario_id from conta join categoria on conta.categoria_id = categoria.id where conta.id = ? and categoria.usuario_id = ?);");
                $sql->execute(array(
                    $id,
                    $_SESSION["usuario_id"],
                    $id,
                    $_SESSION["usuario_id"]
                ));

                if ($sql->rowCount() == 0) {
                    return "Inexistente ou Inacessível";
                } else {
                    return $sql->fetchAll(PDO::FETCH_CLASS)[0]->nome;
                }

            } else {
                header("location: contas.php");
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
                $sql = $con->prepare("delete from conta where conta.id = ? and ? = (select usuario_id from conta join categoria on conta.categoria_id = categoria.id where conta.id = ? and categoria.usuario_id = ?);");

                $sql->execute(array(
                    $id,
                    $_SESSION["usuario_id"],
                    $id,
                    $_SESSION["usuario_id"]
                ));

                if ($sql->rowCount() > 0) {
                    header("location: contas.php");
                }
            } else {
                header("location: contas.php");
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
                $this->tipo = $_POST["tipo"] == "D" ? "D" : "R";
                $this->categoria_id = $_POST["categoria"];

                try {
                    $bd = new Conexao();
                    $con = $bd->conectar();
                    $sql = $con->prepare("insert into conta(id, nome, tipo, categoria_id) values(null, ?, ?, ?)");
                    $sql->execute(array(
                        $this->nome,
                        $this->tipo,
                        $this->categoria_id
                    ));
                } catch (PDOException $msg) {
                    echo "Erro ao inserir conta: {$msg->getMessage()}";
                }
            }
        }
    }

    public function ListarTodos()
    {
        try {
            $bd = new Conexao();
            $con = $bd->conectar();
            $sql = $con->prepare("select conta.id, conta.nome, conta.tipo, categoria.nome as categoria_id from conta join categoria on categoria.id = conta.categoria_id where categoria.usuario_id = ? order by id");
            $sql->execute(array(
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