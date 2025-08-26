<?php
require_once "Conexao.php";

class Movimentacao
{
    public $id;
    public $valor;
    public $data;
    public $conta_id;
    public $usuario_id;

    public function Alterar($id)
    {
        if (isset($_POST["conta"]) && isset($_POST["enviar"])) {
            if (isset($_SESSION["usuario_id"])) {
                $this->id = $id;
                $this->conta_id = $_POST["conta"];
                $this->valor = $_POST["valor"];
                $this->usuario_id = $_SESSION["usuario_id"];

                try {
                    $bd = new Conexao();
                    $con = $bd->conectar();
                    $sql = $con->prepare("update movimentacao set valor = ?, conta_id = ? where id = ? and usuario_id = ?;");
                    $sql->execute(array(
                        $this->valor,
                        $this->conta_id,
                        $this->id,
                        $this->usuario_id
                    ));

                } catch (PDOException $msg) {
                    echo "Erro ao alterar movimentacão: {$msg->getMessage()}";
                }
            }
        }
    }

    public function Excluir($id)
    {
        try {
            if (isset($id)) {
                $bd = new Conexao();
                $con = $bd->conectar();
                $sql = $con->prepare("delete from movimentacao where id = ? and usuario_id = ?");

                $sql->execute(array(
                    $id,
                    $_SESSION["usuario_id"]
                ));

                if ($sql->rowCount() > 0) {
                    header("location: movimentacao.php");
                }
            } else {
                header("location: movimentacao.php");
            }
        } catch (PDOException $msg) {
            echo "Não foi possível excluir:" . $msg->getMessage();
        }
    }

    public function Inserir()
    {
        if (isset($_POST["valor"]) && isset($_POST["enviar"])) {
            if (isset($_SESSION["usuario_id"])) {
                $this->valor = $_POST["valor"];
                $this->conta_id = $_POST["conta"];
                $this->usuario_id = $_SESSION["usuario_id"];
                $this->data = date("Y/m/d");

                try {
                    $bd = new Conexao();
                    $con = $bd->conectar();
                    $sql = $con->prepare("insert into movimentacao(id, valor, data, conta_id, usuario_id) values(null, ?, ?, ?, ?)");
                    $sql->execute(array(
                        $this->valor,
                        $this->data,
                        $this->conta_id,
                        $this->usuario_id
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
            $sql = $con->prepare("select movimentacao.id, conta.nome, movimentacao.valor, movimentacao.data from movimentacao join conta on movimentacao.conta_id = conta.id where movimentacao.usuario_id = ? order by data, id");
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

    public function ObterReceita() {
        try {
            if (isset($_SESSION["usuario_id"])) {
                $bd = new Conexao();
                $con = $bd->conectar();
                $sql = $con->prepare("select sum(valor) as receita from movimentacao join conta on conta.id = movimentacao.conta_id where conta.tipo = 'R' and movimentacao.usuario_id = ?");
                $sql->execute(array(
                    $_SESSION["usuario_id"]
                ));

                if ($sql->rowCount() > 0) {
                    return $sql->fetchAll(PDO::FETCH_CLASS)[0]->receita;
                } else {
                    return 0.00;
                }

            } else {
                header("location: index.html");
            }
        } catch (PDOException $msg) {
            echo "Não foi obter receita:" . $msg->getMessage();
        }
    }

    public function ObterCadaReceita() {
        try {
            if (isset($_SESSION["usuario_id"])) {
                $bd = new Conexao();
                $con = $bd->conectar();
                $sql = $con->prepare("select * from movimentacao join conta on conta.id = movimentacao.conta_id where conta.tipo = 'R' and movimentacao.usuario_id = ? order by movimentacao.id");
                $sql->execute(array(
                    $_SESSION["usuario_id"]
                ));

                if ($sql->rowCount() > 0) {
                    return $sql->fetchAll(PDO::FETCH_CLASS);
                }

            } else {
                header("location: index.html");
            }
        } catch (PDOException $msg) {
            echo "Não foi obter receita:" . $msg->getMessage();
        }
    }

    public function ObterDespesa() {
        try {
            if (isset($_SESSION["usuario_id"])) {
                $bd = new Conexao();
                $con = $bd->conectar();
                $sql = $con->prepare("select sum(valor) as despesa from movimentacao join conta on conta.id = movimentacao.conta_id where conta.tipo = 'D' and movimentacao.usuario_id = ? order by movimentacao.id");
                $sql->execute(array(
                    $_SESSION["usuario_id"]
                ));

                if ($sql->rowCount() > 0) {
                    return $sql->fetchAll(PDO::FETCH_CLASS)[0]->despesa;
                } else {
                    return 0.00;
                }

            } else {
                header("location: index.html");
            }
        } catch (PDOException $msg) {
            echo "Não foi obter despesa:" . $msg->getMessage();
        }
    }

    public function ObterCadaDespesa() {
        try {
            if (isset($_SESSION["usuario_id"])) {
                $bd = new Conexao();
                $con = $bd->conectar();
                $sql = $con->prepare("select * from movimentacao join conta on conta.id = movimentacao.conta_id where conta.tipo = 'D' and movimentacao.usuario_id = ? order by movimentacao.id");
                $sql->execute(array(
                    $_SESSION["usuario_id"]
                ));

                if ($sql->rowCount() > 0) {
                    return $sql->fetchAll(PDO::FETCH_CLASS);
                }

            } else {
                header("location: index.html");
            }
        } catch (PDOException $msg) {
            echo "Não foi obter despesa:" . $msg->getMessage();
        }
    }

    public function ObterAmbos() {
        try {
            if (isset($_SESSION["usuario_id"])) {
                $bd = new Conexao();
                $con = $bd->conectar();
                $sql = $con->prepare("select * from movimentacao join conta on conta.id = movimentacao.conta_id where movimentacao.usuario_id = ? order by movimentacao.id");
                $sql->execute(array(
                    $_SESSION["usuario_id"]
                ));

                if ($sql->rowCount() > 0) {
                    return $sql->fetchAll(PDO::FETCH_CLASS);
                }

            } else {
                header("location: index.html");
            }
        } catch (PDOException $msg) {
            echo "Não foi obter receita:" . $msg->getMessage();
        }
    }
}