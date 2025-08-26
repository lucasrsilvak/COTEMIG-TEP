<?php

require_once "Classes/Usuario.php";

$usuario = new Usuario();

session_start();

if (!isset($_SESSION["usuario_id"]))
{
    header("location: index.html");
}

if (isset($_GET["p"]))
{
    $usuario->ColetarDados([$_GET["p"]]);
} else {
    $usuario->ColetarDados($_SESSION["usuario_id"]);
    header("location: perfil?={$_SESSION["usuario_id"]}");
}

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
                <a class="dropdown-item montserrat text-advise" href="perfil.php?p=<?php echo $_SESSION["usuario_id"]; ?>"><i class="fa fa-user-o"></i> Perfil</a>
                <a class="dropdown-item montserrat" href="alterar.php"><i class="fa fa-floppy-o"></i> Alterar Dados</a>
            </div>
        </label>

        <label class="dropdown nav-item text-white">
            <button class="btn dropdown-toggle montserrat text-white nav-item" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i class="fa fa-cog"></i> Gerenciar Cadastros
            </button>
            <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                <a class="dropdown-item montserrat" href="categorias.php"><i class="fa fa-book"></i> Categorias</a>
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
    <div class="small2 bg-white border-top-radius">
        <div class="bg-dark border-bottom-radius">
            <div class="h3 text-white bg-white-alpha paddingA notRadius"><i class="fa fa-user"></i> Perfil</div>
            <div class="h3 text-white bg-white-alpha paddingA notRadius"></div>
            <div class="h5 text-white bg-white-alpha paddingA notRadius profile-barrier"><i class="fa fa-pencil" data-toggle="tooltip" data-placement="top" title="Nome"></i> <?php echo $usuario->nome?></div>
            <div class="h5 text-white bg-white-alpha paddingA notRadius"></div>
            <div class="h5 text-white bg-white-alpha paddingA notRadius profile-barrier"><i class="fa fa-envelope" data-toggle="tooltip" data-placement="top" title="E-Mail"></i> <?php echo $usuario->email?></div>
            <div class="h5 text-white bg-white-alpha paddingA notRadius"></div>
            <div class="h5 text-white bg-white-alpha paddingA notRadius profile-barrier"><i class="fa fa-street-view" data-toggle="tooltip" data-placement="top" title="Endereço"></i> <?php echo $usuario->endereco?></div>
            <div class="h5 text-white bg-white-alpha paddingA notRadius"></div>
            <div class="h5 text-white bg-white-alpha paddingA notRadius profile-barrier"><i class="fa fa-user" data-toggle="tooltip" data-placement="top" title="Telefone"></i> <?php echo $usuario->telefone?></div>
            <div class="h5 text-white bg-white-alpha paddingA notRadius"></div>
            <div class="bg-white-alpha border-bottom-radius not-invisible">.</div>
        </div>
    </div>

    <script type="text/javascript" src="script.js"></script>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script></html>
</body>
