<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Resultado de Evaluacion</title>
    <style>
        body {
            background-color: gray;             /* Color de fondo */
            font-family: Arial, Helvetica, sans-serif; /* Arial */
            color: black;                       /* Color del texto */
        }
        .contenedor {
            background-color: white;   /* Color de fondo */
            width: 500px;              /* Ancho del Cuadro */
            margin: 50px auto;         /* Espacio entre el cuadro */
            padding: 20px;             /* Espacio Entre el Texto */
        }
        h2 {
           text-align: center;  /* Centra el título */
           font-weight: bold;   /* Texto en negrita */
        }
        p {
           font-weight: bold;   /* Texto Negro */
           margin: 10px 0;      /* Espacio de Cada Respuesta */
        }
    </style>
</head>
<body>

<div class="contenedor">
    <h2>Resultado de Evaluacion</h2>

    <?php
    // Solo procesar si viene por POST
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        // Guardar datos
        $Nombre = $_POST["Nombre"]; 
        $Materia = $_POST["Materia"];
        $Genero = $_POST["Genero"];
        $Cal1 = $_POST["Cal1"];
        $Cal2 = $_POST["Cal2"];
        $Cal3 = $_POST["Cal3"];

        // Calcular promedio
        $Promedio = ($Cal1 + $Cal2 + $Cal3) / 3;

        // Calificacioes /Preproado,Ordinrio,Extra
        if ($Promedio <= 69) 
        {
            $Estatus = "Reprobado";
             $Color = "red"; // Color rojo
        } 
        else {
            if ($Promedio >= 70 && $Promedio <= 95) 
            {
                $Estatus = "Ordinario";
                $Color = "orange"; // Color naranja
            } 
            else {
                if ($Promedio >= 96) 
                {
                    $Estatus = "Exento";
                    $Color = "green"; // Color verde
                }
            }
        }

        // Mostrar Resultados
            echo "<p>Nombre: $Nombre</p>";
            echo "<p>Género: $Genero</p>";
            echo "<p>Materia: $Materia</p>";
            echo "<p>Promedio: " . round($Promedio, 2) . "</p>";

        // Color del Estatus
            echo "<p>Estatus: <span style='Color: $Color;'>$Estatus</span></p>";
    } else {
        echo "<p>No se recibieron datos.</p>";
    }
    ?>
</div>

</body>
</html>