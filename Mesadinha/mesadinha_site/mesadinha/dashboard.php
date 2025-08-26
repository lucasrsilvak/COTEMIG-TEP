<?php

require_once "Classes/Usuario.php";
require_once "Classes/Movimentacao.php";

$usuario = new Usuario();
session_start();



if (isset($_POST["log-in"]))
{
    $usuario->Entrar();
    $_SESSION["usuario_id"] = $usuario->id;
}

if (!isset($_SESSION["usuario_id"]))
{
    header("location: index.html");
}

$i = 0;
$j = 0;
$k = 0;

$mov = new Movimentacao();

$listaR = $mov->ObterCadaReceita();
$listaD = $mov->ObterCadaDespesa();
$listaA = $mov->ObterAmbos();

$totalR = $mov->ObterReceita();
$totalD = $mov->ObterDespesa();

$Tsaldo = 0;

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
        <a href="dashboard.php"><button class="btn title montserrat nav-item text-advise">
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
        <div class="h3 text-white bg-white-alpha paddingA notRadius" id="alterCount"><i class="fa fa-bar-chart"></i> Resumo e Gráfico</div>
        <table class="container table table-dark">
            <thead>
            <th>Receita</th>
            <th>Despesa</th>
            <th>Saldo</th>
            </thead>
            <tbody>
            <td class="green h3"><?php echo "R$ " . number_format($mov->ObterReceita(),2, ",", ".") ; ?></td>
            <td class="red h3"><?php echo "R$ " . number_format($mov->ObterDespesa(),2, ",", ".") ; ?></td>
            <?php
            $saldo = floatval($mov->ObterReceita()) - floatval($mov->ObterDespesa());
            if ($saldo >= 0) {
                ?> <td class="green h3"><?php echo "R$ " . number_format($saldo, 2, ",", ".") ?></td><?php
            } else {
                ?> <td class="red h3"><?php echo "R$ " . number_format($saldo, 2, ",", ".") ?></td><?php
            }
            ?>
            </tbody>
        </table>

<div class="container margin-top-10 d-flex flex-row mb-3 justify-content-center bg-grey">
    <div class="width-25-percent p-2">
        <canvas id="receitas" width="200" height="200"></canvas>
    </div>
    <div class="width-25-percent p-2">
        <canvas id="despesas" width="200" height="200"></canvas>
    </div>
    <div class="width-25-percent p-2">
        <canvas id="totalbar" width="200" height="200"></canvas>
    </div>
    <div class="width-25-percent p-2">
        <canvas id="ambosline" width="200" height="200"></canvas>
    </div>
 </div>
<div class="bg-white-alpha border-bottom-radius not-invisible">.</div>
    </div>
</div>


        <script type="text/javascript" src="script.js"></script>
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script> </html>
<script src="chart.min.js"></script>
<script src="path/to/chartjs/dist/Chart.js"></script>
<script>
    var myChart = new Chart(ctx, {...});
</script>
<script>
    var ctx = document.getElementById('despesas');
    var myChart = new Chart(ctx, {
        type: 'line',
        data: {
            labels: [
                <?php
                foreach ($listaD as $D) {
                    $j++;
                    echo $j . ",";
                }
                ?>],
            datasets: [{
                label: 'Dados de Despesas',
                data: [
                    <?php
                    foreach ($listaD as $D) {
                        echo $D->valor . "," ;
                    }
                    ?>],
                backgroundColor: [
                    'rgba(207, 37, 17, 0.5)'
                ],
                borderColor: [
                    'rgba(207, 37, 17, 1)'
                ],
                borderWidth: 1
            }]
        },
        options: {
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero: true
                    }
                }]
            }
        }
    });
</script>
<script>
    var ctx = document.getElementById('ambosline');
    var myChart = new Chart(ctx, {
        type: 'line',
        data: {
            labels: [0,
                <?php
                foreach ($listaA as $A) {
                    $k++;
                    echo $k . ",";
                }
                ?>],
            datasets: [{
                label: 'Saldo móvel',
                data: [0,
                    <?php
                    foreach ($listaA as $A) {
                        if ($A->tipo == 'D') {
                            $Tsaldo = $Tsaldo - floatval($A->valor);
                            echo $Tsaldo . ", ";
                        } else {
                            $Tsaldo = $Tsaldo + floatval($A->valor);
                            echo $Tsaldo . ", ";
                        }
                    }
                    ?>],
                backgroundColor: [
                    'rgba(17, 37, 207, 0.5)'
                ],
                borderColor: [
                    'rgba(17, 37, 207, 1)'
                ],
                borderWidth: 1
            }]
        },
        options: {
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero: true
                    }
                }]
            }
        }
    });
</script>
<script>
    var ctx = document.getElementById('receitas');
    var myChart = new Chart(ctx, {
        type: 'line',
        data: {
            labels: [
                <?php
                    foreach ($listaR as $R) {
                        $i++;
                        echo $i . ",";
                    }
                ?>],
            datasets: [{
                label: 'Dados de Receita',
                data: [
                    <?php
                        foreach ($listaR as $R) {
                            echo $R->valor . "," ;
                        }
                    ?>],
                backgroundColor: [
                    'rgba(0, 145, 107, 0.2)'

                ],
                borderColor: [
                    'rgba(0, 145, 107, 0.6)'
                ],
                borderWidth: 1
            }]
        },
        options: {
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero: true
                    }
                }]
            }
        }
    });
</script>

<script>
    var ctx = document.getElementById('totalbar');
    var myChart = new Chart(ctx, {
        type: 'bar',
        data: {
            labels: ['Despesas', 'Receita'],
            datasets: [{
                label: 'Dados Totais',
                data: [
                    <?php
                    echo $totalD . ", " . $totalR;
                    ?>],
                backgroundColor: [
                    'rgba(207, 37, 17, 0.5)',
                    'rgba(0, 145, 107, 0.5)',
                ],
                borderColor: [
                    'rgba(207, 37, 17, 1)',
                    'rgba(0, 145, 107, 1)',
                ],
                borderWidth: 1
            }]
        },
        options: {
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero: true
                    }
                }]
            }
        }
    });
</script>
</body>