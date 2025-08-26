<?php
require_once "Classes/Conta.php";
require_once "Classes/Movimentacao.php";

$movimentacao = new Movimentacao();
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

        $movimentacao->Alterar($_SESSION["id"]);
        unset($_SESSION['alterar']);

    }
    else
    {
        $movimentacao->Inserir();
    }
}
else
{
    if (isset($_GET["m"]))
    {
        $movimentacao->Excluir($_GET["m"]);
    }
    elseif (isset($_GET["a"]))
    {
        $nome = true;

        if ($nome) {
            ?>
            <script>
                var alter = true
            </script>
            <?php
            $_SESSION["id"] = $_GET["a"];
            $_SESSION["alterar"] = "";
        }
    }
}

$conta = new Conta();

$listaConta = $conta->ListarTodos();
$listaMovimentacao = $movimentacao->ListarTodos();

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
                <a class="dropdown-item montserrat" href="contas.php"><i class="fa fa-file-text"></i> Contas</a>
            </div>
        </label>

        <a href="movimentacao.php"><button class="title montserrat btn text-white nav-item text-advise">
                <i class="fa fa-line-chart"></i> Lançamento
            </button></a>
    </div>
    <a href="sair.php"><button class="title montserrat btn text-white nav-item">
            <i class="fa fa-share"></i> Sair
        </button></a>
</nav>

<div class="container-60 config-of-container">
    <div class="small2 bg-dark border-top-radius">
        <div class="h3 text-white bg-white-alpha paddingA notRadius" id="alterCount"><i class="fa fa-exchange"></i> Balanço</div>
        <table class="container table table-dark">
            <thead>
            <th>Receita</th>
            <th>Despesa</th>
            <th>Saldo</th>
            </thead>
            <tbody>
            <td class="green h3"><?php echo "R$ " . number_format($movimentacao->ObterReceita(),2, ",", ".") ; ?></td>
            <td class="red h3"><?php echo "R$ " . number_format($movimentacao->ObterDespesa(),2, ",", ".") ; ?></td>
                <?php
                $saldo = floatval($movimentacao->ObterReceita()) - floatval($movimentacao->ObterDespesa());
                if ($saldo >= 0) {
                ?> <td class="green h3"><?php echo "R$ " . number_format($saldo, 2, ",", ".") ?></td><?php
                } else {
                ?> <td class="red h3"><?php echo "R$ " . number_format($saldo, 2, ",", ".") ?></td><?php
                }
                ?>
            </tbody>
        </table>
        <div class="small2 bg-dark border-top-radius">
        <div class="h3 text-white bg-white-alpha paddingA notRadius" id="alterCount"><i class="fa fa-line-chart"></i> Nova Movimentação</div>
        <form class="bg-dark notRadius no-margin-bottom" method="post" action="movimentacao.php">
            <!-- Tipo  --><div class="form-group">
                <label for="name" class="text-white">Categoria</label><br>
                <select for="name" class="btn text-dark bg-white width-100-percent" name="conta" required>
                    <option>Selecione</option>
                    <?php
                    if ($listaConta) :
                        foreach($listaConta as $conta) : ?>
                            <option value="<?php echo $conta->id; ?>"><?php echo $conta->nome; ?></option>
                        <?php endforeach;
                    else : ?>
                    <?php endif; ?>
                </select><br>
                <!-- Nome  --><div class="form-group">
                    <label for="name" class="text-white">Valor</label>
                    <input class="form-control" name="valor" type="=number" step="any">
                </div>
            </div>

            <div class="form-group text-center">
                <button type="submit" class="btn btn-success fullfill font-weight-bold" name="enviar" id="enviar">Enviar <i class="fa fa-check"></i></button>
            </div>
        </form>
    </div>
    <div class="small2 bg-white border-top-radius">
        <div class="bg-dark border-bottom-radius">
            <div class="h3 text-white bg-white-alpha paddingA notRadius"><i class="fa fa-folder-open"></i> Lista de Movimentações</div>
            <div>
                <table class="container table table-dark">
                    <thead>
                    <th>Conta</th>
                    <th>Valor</th>
                    <th>Data</th>
                    <th></th>
                    </thead>
                    <tbody>
                    <?php
                    if ($listaMovimentacao) :
                        foreach ($listaMovimentacao as $movimentacao) : ?>
                            <tr>
                                <td><?php echo$movimentacao->nome; ?></td>
                                <td>R$ <?php echo$movimentacao->valor; ?></td>
                                <?php $date = date_create($movimentacao->data) ?>
                                <td><?php echo date_format($date, "d-m-Y"); ?></td>
                                <td></td>
                                <td>
                                    <a href="movimentacao.php?m=<?php echo $movimentacao->id; ?>" class="btn btn-danger">
                                        <i class="fa fa-trash"></i>
                                    </a>
                                </td>
                                <td><a href="movimentacao.php?a=<?php echo $movimentacao->id; ?>" class="btn btn-primary"><i class="fa fa-edit"></i></a></td>
                            </tr>
                        <?php endforeach;
                    else : ?>
                        <tr>
                            <td colspan="4">Nenhuma movimentação encontrada</td>
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
            document.getElementById("alterCount").innerHTML = "Alterando a Movimentação";
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