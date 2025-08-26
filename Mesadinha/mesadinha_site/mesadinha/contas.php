<?php
require_once "Classes/Conta.php";
require_once "Classes/Categoria.php";

$conta = new Conta();
session_start();

if (!isset($_SESSION["usuario_id"]))
{
    header("location: index.html");
}

?>
<script>var alter = null</script>
<?php

if (isset($_POST["enviar"]))
{

    if (isset($_SESSION["alterar"]))
    {

        $conta->Alterar($_SESSION["id"]);
        unset($_SESSION['alterar']);

    }
    else
    {
        $conta->Inserir();
    }
}
else
{
    if (isset($_GET["m"]))
    {
        $conta->Excluir($_GET["m"]);
    }
    elseif (isset($_GET["a"]))
    {
        $nome = null;
        $nome = $conta->ObterNome($_GET["a"]);

        if ($nome) {
            ?>
            <script>
                var alter = <?php echo " \"$nome\" "; ?>;
            </script>
            <?php
            $_SESSION["id"] = $_GET["a"];
            $_SESSION["alterar"] = "";
        }
    }
}

$listaConta = $conta->ListarTodos();

$categoria = new Categoria();
$listaCategorias = $categoria->ListarTodos();

?>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Mesadinha</title>
    <link href="bootstrap-4.5.3-dist/css/bootstrap.min.css" rel="stylesheet" media="screen">
    <link href="bootstrap-4.5.3-dist/js/bootstrap.min.css" rel="stylesheet" media="screen">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="style.css" rel="stylesheet">
</head>
<body class="bg-white">

<nav class="bg-dark flex-row-2">
    <div class="flex-row nav-item-2">
        <label class="title font-weight-bold montserrat text-white nav-item-2">Controle Financeiro Pessoal</label>
        <a href="dashboard.php"><button class="btn title montserrat text-white nav-item">
                <i class="fa fa-home"></i> Home
            </button></a>

        <label class="dropdown  text-white nav-item">
            <button class="btn dropdown-toggle montserrat text-white nav-item" type="button" id="dropdownUserButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i class="fa fa-user"></i> Usuário
            </button>
            <div class="dropdown-menu" aria-labelledby="dropdownUserButton">
                <a class="dropdown-item montserrat" href="perfil.php?p=<?php echo $_SESSION["usuario_id"]; ?>"><i class="fa fa-user-o"></i> Perfil</a>
                <a class="dropdown-item montserrat" href="alterar.php"><i class="fa fa-floppy-o"></i> Alterar Dados</a>
            </div>
        </label>

        <label class="dropdown nav-item text-white">
            <button class="btn dropdown-toggle montserrat text-white nav-item" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i class="fa fa-cog"></i> Gerenciar Cadastros
            </button>
            <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                <a class="dropdown-item montserrat" href="categorias.php"><i class="fa fa-book"></i> Categorias</a>
                <a class="dropdown-item montserrat text-advise" href="contas.php"><i class="fa fa-file-text"></i> Contas</a>
            </div>
        </label>

        <a href="movimentacao.php"><button class="title montserrat btn text-white nav-item">
                <i class="fa fa-line-chart"></i> Lançamento
            </button></a>
    </div>
    <a href="sair.php"><button class="title montserrat btn text-white nav-item">
            <i class="fa fa-share"></i> Sair
        </button></a>
</nav>

<div class="container-60 config-of-container">
    <div class="small2 bg-dark border-top-radius">
        <div class="h3 text-white bg-white-alpha paddingA notRadius" id="alterCount"><i class="fa fa-file-text"></i> Nova Conta</div>
        <form class="bg-dark notRadius no-margin-bottom" method="post" action="contas.php">
            <!-- Nome  --><div class="form-group">
                <label for="name" class="text-white">Nome</label>
                <input class="form-control" name="name" required maxlength="30">
            </div>

            <!-- Tipo  --><div class="form-group">
                <label for="name" class="text-white">Tipo</label><br>
                <select for="name" class="btn text-dark bg-white width-100-percent" name="tipo" id="tipo" required>
                    <option>Selecione</option>
                    <option value="D" class="btn">Despesa</option>
                    <option value="R" class="btn">Receita</option>
                </select>
            </div>
            <!-- Tipo  --><div class="form-group">
                <label for="name" class="text-white">Categoria</label><br>
                <select for="name" class="btn text-dark bg-white width-100-percent" name="categoria" id="categoria" required>
                    <option>Selecione</option>
                    <?php
                    if ($listaCategorias) :
                        foreach($listaCategorias as $categoria) : ?>
                        <option value="<?php echo $categoria->id; ?>"><?php echo $categoria->nome; ?></option>
                    <?php endforeach;
                    else : ?>
                    <?php endif; ?>
                </select>
            </div>

            <div class="form-group text-center">
                <button type="submit" class="btn btn-success fullfill font-weight-bold" name="enviar" id="enviar">Enviar <i class="fa fa-check"></i></button>
            </div>
        </form>
    </div>
    <div class="small2 bg-white border-top-radius">
        <div class="bg-dark border-bottom-radius">
            <div class="h3 text-white bg-white-alpha paddingA notRadius"><i class="fa fa-folder-open"></i> Lista de Contas</div>
            <div>
                <table class="container table table-dark">
                    <thead>
                    <th>Nome</th>
                    <th>Tipo</th>
                    <th>Categoria</th>
                    <th></th>
                    </thead>
                    <tbody>
                    <?php
                    if ($listaConta) :
                        foreach ($listaConta as $conta) : ?>
                            <tr>
                                <td><?php echo$conta->nome; ?></td>
                                <td>
                                    <?php
                                        if ($conta->tipo != "D") : ?>
                                            <i class="fa fa-arrow-up green" data-toggle="tooltip" data-placement="top" title="Receita"></i>
                                    <?php else : ?>
                                            <i class="fa fa-arrow-down red"  data-toggle="tooltip" data-placement="top" title="Despesa"></i>
                                    <?php endif ?>
                                <td><?php echo$conta->categoria_id; ?></td>
                                <td></td>
                                <td>
                                    <a href="contas.php?m=<?php echo $conta->id; ?>" class="btn btn-danger">
                                        <i class="fa fa-trash"></i>
                                    </a>
                                </td>
                                <td><a href="contas.php?a=<?php echo $conta->id; ?>" class="btn btn-primary"><i class="fa fa-edit"></i></a></td>
                            </tr>
                        <?php endforeach;
                    else : ?>
                        <tr>
                            <td colspan="4">Nenhuma conta encontrada</td>
                        </tr>
                    <?php endif;
                    ?>
                    </tbody>
                </table>
            </div>
            <div class="bg-white-alpha border-bottom-radius not-invisible">.</div>
        </div>
    </div>
    <script type="text/javascript" src="script.js"></script>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <script>
        if (alter)
        {
            document.getElementById("alterCount").innerHTML = "Alterando a Conta \"" + alter + "\"";
            <?php
                if (isset($_SESSION['alterar']))
                {
                    $_SESSION['alterar'] = true;
                }
            ?>
        }
    </script>
</body>
</html>