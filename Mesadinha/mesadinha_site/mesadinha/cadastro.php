<?php
    require_once "Classes/Usuario.php";

    $result = "nothing";
    $usuario = new Usuario();

    if (isset($_POST["entrar"])) {
        if ($usuario->Inserir() == "exists") {
            ?>
            <script>
                var alreadyExist = true;
            </script>
            <?php
        }
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
<body class="bg-dark">
<form class="small bg-white" method="post" action="cadastro.php">
    <!-- Nome  --><div class="form-group">
        <label for="name" class="text-dark">Nome</label>
        <input class="form-control" name="name" required>
    </div>
    <!-- Senha --><div class="form-group">
        <label for="password" class="text-dark">Senha</label>
        <input type="password" class="form-control" name="password" required>
    </div>
    <!-- Email --><div class="form-group">
        <label for="email" class="text-dark">E-mail</label>
        <input type="email" class="form-control" name="email" aria-describedby="emailHelp" required onfocus="removeAlert()">
        <label class="mySmall red" id="Help" class="form-text text-muted"></label>
    </div>
    <!-- Ender --><div class="form-group">
        <label for="address" class="text-dark">Endereço</label>
        <input class="form-control" name="address" required>
    </div>
    <!-- Telef --><div class="form-group">
        <label for="cellphone" class="text-dark">Telefone</label>
        <input class="form-control" name="cellphone" id="telephone" onkeypress="telephoneMask()" required minlength="15" maxlength="15">
        <script>
            if (alreadyExist)
            {
                var small = document.getElementById("Help")
                small.innerHTML = "Email já cadastrado!";
                small.style.Color = "#FF0000";
            }
        </script>
    </div>

    <div class="form-group text-center">
        <a href="index.html" class="btn btn-primary fullfill">Voltar</a>
        <button type="submit" class="btn btn-success fullfill" name="entrar" id="entrar">Enviar</button>
    </div>
</form>
</body>
<script type="text/javascript" src="script.js"></script>
</html>