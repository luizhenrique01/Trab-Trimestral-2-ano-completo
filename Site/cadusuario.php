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
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
<div class="tudo">
     <div class="login">
<!--          logo da empresa-->
         <div align="center">

             <img src="img/mapa.png">
                  </div>
         <form action="">

             <div class="form-group">
                 <label for="email">Nome</label>
                 <input type="text" name="nome" class="form-control" required>
             </div>

             <div class="form-group">
                 <label for="endereco">Endereço</label>
                 <input type="text" name="nome" class="form-control"  required>
             </div>

             <div class="form-group">
                 <label for="email">CEP</label>
                 <input type="number" name="cep" class="form-control" placeholder="32.148-552" required>
             </div>

             <div class="form-group">
                 <label for="email">Telefone</label>
                 <input type="number" name="fone" class="form-control" placeholder="(31)99248-6912" required>
             </div>

             <div class="form-group">
                 <label for="email">CPF</label>
                 <input type="number" name="cpf" class="form-control" placeholder="063.234.654-01" required>
             </div>

             <div class="form-group">
                 <label for="email">E-mail</label>
                 <input type="email" name="email" class="form-control" placeholder="email@email.com.br" required>
             </div>
             <div class="form-group">
                 <label for="senha">Senha</label>
                 <input type="password" name="senha" class="form-control" minlength="6" maxlength="15" placeholder="
******" required>
             </div>
             <div align="center">
                 <button class="btn btn-success" type="submit">Salvar</button>
                 <a href="index.php" class="btn btn-outline-primary">Voltar</a>
             </div>


         </form>

     </div>
</div>


</body>
</html