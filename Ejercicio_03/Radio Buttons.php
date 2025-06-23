<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Resultado</title>
    <link rel="stylesheet" href="Radio Buttons.css">
</head>
<body>
    <div class="contenedor">
        <h1>Datos recibidos</h1>

        <?php
        $Nombre = $_POST['nombre'];
        $Edad = $_POST['edad'];
        $Genero = $_POST['genero'];

        echo "<p><strong>Nombre:</strong> $Nombre</p>";
        echo "<p><strong>Edad:</strong> $Edad</p>";
        echo "<p><strong>Género:</strong> $Genero</p>";
        ?>

        <form action="Radio Buttons.html" method="get">
            <input type="submit" value="Volver">
        </form>
    </div>
</body>
</html>