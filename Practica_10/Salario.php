<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Resultado del Salario</title>
    <link rel="stylesheet" href="salario.css">
</head>
<body>
    <div class="contenedor">
        <h1>RESULTADO DEL SALARIO</h1>

        <?php
        $Empleado = $_POST['empleado']; 
        $Horas = $_POST['horas']; 
        $Categoria = $_POST['categoria']; 
        $Descuento = 10;

        if ($Categoria == "jefe") {
            $Pago_Hora = 450;
        } else if ($Categoria == "administrativo") {
            $Pago_Hora = 350;
        } else if ($Categoria == "operador") {
            $Pago_Hora = 250;
        } else if ($Categoria == "practicante") {
            $Pago_Hora = 150;
        }

        $Salario_Bruto = $Horas * $Pago_Hora;
        $Desc = $Salario_Bruto * $Descuento / 100;
        $Salario_Neto = $Salario_Bruto - $Desc;

        echo "<p><strong>Empleado:</strong> $Empleado</p>";
        echo "<p><strong>Horas trabajadas:</strong> $Horas</p>";
        echo "<p><strong>Salario bruto:</strong> $$Salario_Bruto</p>";
        echo "<p><strong>Descuento (10%):</strong> $$Desc</p>";
        echo "<p><strong>Salario neto:</strong> $$Salario_Neto</p>";
        ?>
    </div>
</body>
</html>
