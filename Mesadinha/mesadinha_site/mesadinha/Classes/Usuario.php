<?php
require_once "Conexao.php";

class Usuario
{
    public $id;
    public $nome;
    public $email;
    public $endereco;
    public $telefone;
    public $senha;

    private $dadosValidar = ["name", "password", "cellphone", "email", "address"];

    private function validar()
    {
        foreach ($this->dadosValidar as $dado) {
            if (!(isset($_POST[$dado]) && !empty($_POST[$dado]))) {
                return false;
            }
            return true;
        }
    }

    public function Entrar()
    {
        try {

            if (isset($_POST["email"]) && isset($_POST["password"])) {
                $this->senha = $_POST["password"];
                $this->email = $_POST["email"];

                $bd = new Conexao();
                $con = $bd->conectar();
                $sql = $con->prepare("select * from usuario where email = ? and senha = ?");
                $sql->execute(array(
                    $this->email,
                    $this->senha
                ));

                if ($sql->rowCount() == 0) {
                    header("location: index.html");
                } else {
                    $this->id = $sql->fetchAll(PDO::FETCH_CLASS)[0]->id;
                }
            }
        } catch (PDOException $msg) {
            echo "Erro ao entrar: {$msg->getMessage()}";
        }
    }

    public function Inserir()
    {
        try {
            if ($this->validar()) {
                $this->nome = $_POST["name"];
                $this->senha = $_POST["password"];
                $this->email = $_POST["email"];
                $this->endereco = $_POST["address"];
                $this->telefone = $_POST["cellphone"];
            }

            $bd = new Conexao();
            $con = $bd->conectar();
            $sql = $con->prepare("select * from usuario where email = ?");
            $sql->execute(array(
                $this->email
            ));

            if ($sql->rowCount() != 0) {
                return "exists";
            }

            $bd = new Conexao();
            $con = $bd->conectar();
            $sql = $con->prepare("insert into usuario(id, nome, email, endereco, telefone, senha)
                values(null, ?,?,?,?,?) ");
            $sql->execute(array(
                $this->nome,
                $this->email,
                $this->endereco,
                $this->telefone,
                $this->senha
            ));

            if ($sql->rowCount() > 0) {
                header("location: index.html");
            }

        } catch (PDOException $msg) {
            echo "Erro ao cadastrar: {$msg->getMessage()}";
        }
    }

    public function ListarTodos()
    {
        try {
            $bd = new Conexao();
            $con = $bd->conectar();
            $sql = $con->prepare("select * from usuario");
            $sql->execute();

            if ($sql->rowCount() > 0) {
                return $result = $sql->fetchAll(PDO::FETCH_CLASS);
            }
        } catch (PDOException $msg) {
            echo "Retorno com erro: {$msg}";
        }
    }

    public function ColetarDados($id)
    {
        try {
            $bd = new Conexao();
            $con = $bd->conectar();
            $sql = $con->prepare("select * from usuario where id = ?");
            $sql->execute(
                $id
            );

            if ($sql->rowCount() > 0) {
                $result = $sql->fetchAll(PDO::FETCH_CLASS)[0];

                $this->nome     = $result->nome;
                $this->email    = $result->email;
                $this->endereco = $result->endereco;
                $this->telefone = $result->telefone;
                $this->senha    = $result->senha;
            } else {
                die();
                header("location: dashboard.php");
            }
        } catch (PDOException $msg) {
            echo "Retorno com erro: {$msg}";
        }
    }

    public function ColetarSenha($id)
    {
        try {
            $bd = new Conexao();
            $con = $bd->conectar();
            $sql = $con->prepare("select * from usuario where id = ?");
            $sql->execute(array(
                $id
            ));

            if ($sql->rowCount() > 0) {
                $result = $sql->fetchAll(PDO::FETCH_CLASS)[0];

                $this->nome     = $result->nome;
                $this->email    = $result->email;
                $this->endereco = $result->endereco;
                $this->telefone = $result->telefone;
                $this->senha    = $result->senha;
            } else {
                die();
                header("location: dashboard.php");
            }
        } catch (PDOException $msg) {
            echo "Retorno com erro: {$msg}";
        }
    }

    public function Excluir($id)
    {
        try {
            if (isset($id)) {
                $bd = new Conexao();
                $con = $bd->conectar();
                $sql = $con->prepare("delete from usuario where id = ?");

                $sql->execute(array(
                    $id
                ));

                if ($sql->rowCount() > 0) {
                    header("dashboard.php");
                }
            } else {
                header("location: dashboard.php");
            }
        } catch (PDOException $msg) {
            echo "Não foi possível excluir:" . $msg->getMessage();
        }
    }

    public function Alterar($id)
    {
        try {
            $bd = new Conexao();
            $con = $bd->conectar();
            $sql = $con->prepare("update usuario set senha = ? where id = ? ");
            $sql->execute(array(
                $_POST["new"],
                $id
            ));
        } catch (PDOException $msg) {
            echo "Erro ao alterar: {$msg}";
        }
    }
}