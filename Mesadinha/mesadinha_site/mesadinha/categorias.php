<?php
require_once "Classes/Categoria.php";

$categoria = new Categoria();
session_start();

if (!isset($_SESSION["usuario_id"]))
{
    header("location: index.html");
}

?>
<script>var alter = null</script>
<?php

if (isset($_POST["enviar"])) {

    if (isset($_SESSION["alterar"]))
    {
        $categoria->Alterar($_SESSION["id"]);
        unset($_SESSION['alterar']);
    }
    else
    {
        $categoria->Inserir();
    }
}
else
{
    if (isset($_GET["m"]))
    {
        $categoria->Excluir($_GET["m"]);
    }
    elseif (isset($_GET["a"]))
    {
        $nome = null;
        $nome = $categoria->ObterNome($_GET["a"]);

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


$listaCategoria = $categoria->ListarTodos();
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
                <a class="dropdown-item montserrat text-advise" href="categorias.php"><i class="fa fa-book"></i> Categorias</a>
                <a class="dropdown-item montserrat" href="contas.php"><i class="fa fa-file-text"></i> Contas</a>
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
        <div class="h3 text-white bg-white-alpha paddingA notRadius" id="alterCategory"><i class="fa fa-book"></i> Nova Categoria</div>
        <form class="bg-dark notRadius no-margin-bottom" method="post" action="categorias.php">
            <!-- Nome  --><div class="form-group">
                <label for="name" class="text-white">Nome</label>
                <input class="form-control" name="name" required maxlength="30">
            </div>

            <div class="form-group text-center">
                <button type="submit" class="btn btn-success fullfill font-weight-bold" name="enviar" id="enviar">Enviar <i class="fa fa-check"></i></button>
            </div>
        </form>
    </div>
    <div class="small2 bg-white border-top-radius">
        <div class="bg-dark border-bottom-radius">
            <div class="h3 text-white bg-white-alpha paddingA notRadius"><i class="fa fa-institution"></i> Lista de Categorias</div>
            <div>
                <table class="container table table-dark">
                    <thead>
                    <th>Nome</th>
                    <th>Contas</th>
                    <th></th>
                    </thead>
                    <tbody>
                    <?php
                    if ($listaCategoria) :
                        foreach ($listaCategoria as $categoria) : ?>
                            <tr>
                                <td><?php echo$categoria->nome; ?></td>
                                <td><?php echo$categoria->contagem > 0 ? $categoria->contagem : 0; ?></td>
                                <td></td>
                                <td>
                                    <a href="categorias.php?m=<?php echo $categoria->id; ?>" class="btn btn-danger">
                                        <i class="fa fa-trash"></i>
                                    </a>
                                </td>
                                <td><a class="btn btn-primary" href="categorias.php?a=<?php echo $categoria->id; ?>"><i class="fa fa-edit"></i></a></td>
                            </tr>
                        <?php endforeach;
                    else : ?>
                        <tr>
                            <td colspan="3">Nenhuma categoria encontrada</td>
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
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script> </html>
    <script>
        if (alter)
        {
            document.getElementById("alterCategory").innerHTML = "Alterando a Categoria \"" + alter + "\"";
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