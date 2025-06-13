<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Práctica 09 - Tablas de Multiplicar con Ciclos</title>
</head>
<body>
    <h1>Tablas de Multiplicar</h1>

    <!-- Formulario 1: FOR -->
    <form method="post">
        <h2>Usando ciclo FOR</h2>
        <label>Ingresa un número:</label>
        <input type="number" name="numero_for" required>
        <button type="submit" name="btn_for">Generar tabla</button>
    </form>

    <?php
    if (isset($_POST['btn_for'])) {
        $num = intval($_POST['numero_for']);
        echo "<h3>Tabla del $num usando FOR:</h3><ul>";
        for ($i = 1; $i <= 10; $i++) {
            echo "<li>$num x $i = " . ($num * $i) . "</li>";
        }
        echo "</ul>";
    }
    ?>

    <hr>

    <!-- Formulario 2: WHILE -->
    <form method="post">
        <h2>Usando ciclo WHILE</h2>
        <label>Ingresa un número:</label>
        <input type="number" name="numero_while" required>
        <button type="submit" name="btn_while">Generar tabla</button>
    </form>

    <?php
    if (isset($_POST['btn_while'])) {
        $num = intval($_POST['numero_while']);
        echo "<h3>Tabla del $num usando WHILE:</h3><ul>";
        $i = 1;
        while ($i <= 10) {
            echo "<li>$num x $i = " . ($num * $i) . "</li>";
            $i++;
        }
        echo "</ul>";
    }
    ?>

    <hr>

    <!-- Formulario 3: DO WHILE -->
    <form method="post">
        <h2>Usando ciclo DO WHILE</h2>
        <label>Ingresa un número:</label>
        <input type="number" name="numero_dowhile" required>
        <button type="submit" name="btn_dowhile">Generar tabla</button>
    </form>

    <?php
    if (isset($_POST['btn_dowhile'])) {
        $num = intval($_POST['numero_dowhile']);
        echo "<h3>Tabla del $num usando DO WHILE:</h3><ul>";
        $i = 1;
        do {
            echo "<li>$num x $i = " . ($num * $i) . "</li>";
            $i++;
        } while ($i <= 10);
        echo "</ul>";
    }
    ?>
</body>
</html>