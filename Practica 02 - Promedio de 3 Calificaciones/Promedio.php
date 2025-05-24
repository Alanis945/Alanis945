<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Calculadora de Promedio</title>
    <style>
        /* Estilos para la Página */
        body {
            background-color: #f2f2f2; /* Fondo claro */
            font-family: "Times New Roman", Times, serif; /* Fuente Times New Roman */
            font-size: 16px; /* Tamaño de letra aprox 12pt */
            text-align: center; /* Centramos todo el texto */
            margin: 0;
            padding: 0;
        }

        /* Contenedor Principal */
        .container {
            background-color: white; /* Fondo Blanco para la Caja */
            width: 400px; /* Ancho Fijo */
            margin: 80px auto; /* Centramos Vertical y Horizontalmente */
            padding: 30px; /* Espaciado Interno */
            border-radius: 12px; /* Bordes Redondeados */
            box-shadow: 0 0 15px rgba(0,0,0,0.2); /* Sombra Suave */
        }

        /* Estilos para los Campos y Botón */
        input[type="number"], input[type="submit"] {
            padding: 8px;
            width: 80%;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 6px;
            font-family: "Times New Roman", Times, serif;
            font-size: 16px;
        }

        /* Botón Estilo Verde */
        input[type="submit"] {
            background-color: #4CAF50;
            color: white;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        /* Cambio de Color al Pasar el Mouse */
        input[type="submit"]:hover {
            background-color: #45a049;
        }

        /* Espaciados para Títulos y Párrafos */
        h1, h2, p {
            margin-bottom: 15px;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>Calculadora de Promedio</h1>
        
        <!-- Formulario para que el Usuario Ingrese las Calificaciones -->
        <form method="get" action="">
            <label>Calificación 1:</label><br>
            <input type="number" name="cal1" required><br>

            <label>Calificación 2:</label><br>
            <input type="number" name="cal2" required><br>

            <label>Calificación 3:</label><br>
            <input type="number" name="cal3" required><br>

            <input type="submit" value="Calcular Promedio">
        </form>

        <?php
        // Verificamos que las tres calificaciones estén enviadas via GET
        if (isset($_GET['cal1']) && isset($_GET['cal2']) && isset($_GET['cal3'])) {

            // Guardamos las calificaciones en variables para usarlas
            $cal1 = $_GET['cal1'];
            $cal2 = $_GET['cal2'];
            $cal3 = $_GET['cal3'];

            // Calculamos el promedio de las tres calificaciones
            $promedio = ($cal1 + $cal2 + $cal3) / 3;

            // Mostramos el promedio con dos decimales
            echo "<h2>Promedio: " . round($promedio, 2) . "</h2>";

            // Mostrar la calificacion y el resultado mediante el color corespondiente 
            if ($promedio <= 69) {
                echo "<p style='color: red;'>Resultado: Reprobado</p>";
            } elseif ($promedio >= 70 && $promedio <= 94) {
                echo "<p style='color: orange;'>Resultado: Aprobado</p>";
            } else {
                echo "<p style='color: green;'>Resultado: Exento</p>";
            }
        }
        ?>
    </div>
</body>
</html>