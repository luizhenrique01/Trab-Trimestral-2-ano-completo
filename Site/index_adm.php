<?php
header("Content-type:text/html; charset=utf8");

?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <script src="js/jquery-3.4.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</head>
<body>
<nav class="navbar navbar-expand-sm bg-dark navbar-dark">
    <!-- Brand/logo -->
    <a class="navbar-brand" href="#">Sistema de estacionamento 1.0</a>

    <!-- Links -->
    <ul class="navbar-nav">
        <li class="nav-item">
            <a class="nav-link" href="">Cadastrar</a>
        </li>

        <li class="nav-item">
            <a class="nav-link" href="">Planilha Financeira</a>
        </li>

        <li class="nav-item">
            <a class="nav-link" href="">Histórico</a>
        </li>

        <li class="nav-item">
            <a class="nav-link" href="index.php">Sair</a>
        </li>
    </ul>
</nav>

<div class="container">

    <div class="row" style="padding-top: 10px">
        <div class="col-sm-4" style="background: linear-gradient(to left, #ffcc00 0%, #66ffff 100%); font-family: Roboto; font-size: 20px">
            Motos<br> <img src="img/mot.png" style="padding-right: 10px"> <label style="padding-left: 100px;font-size: 50px">387</label>
        </div>

        <div class="col-sm-4" style="background: linear-gradient(to left, #ffcc00 0%, #66ffff 100%); font-family: Roboto; font-size: 20px">
            Carros<br> <img src="img/car.png" style="padding-right: 10px"> <label style="padding-left: 100px;font-size: 50px">12</label>
        </div>

        <div class="col-sm-4" style="background: linear-gradient(to left, #ffcc00 0%, #66ffff 100%); font-family: Roboto; font-size: 20px">
            Caminhões<br> <img src="img/caminhao.png" style="padding-right: 10px"> <label style="padding-left: 100px;font-size: 50px">5</label>
        </div>

    </div>



</div>
</body>
</html