<?php
//Capturar los Datos Enviados Desde el Formulario
$Nombre = $_POST['nombre'];
$Edad = $_POST['edad'];
$Funcion = $_POST['funcion'];
$Estudiante = isset($_POST['credencial']); // Devuelve true si es Estudiante

// Define los Precios de Tipo de Funcion
switch ($Funcion) {
    case '2D':
        $PrecioBase = 40;
        break;
    case '3D':
        $PrecioBase = 60;
        break;
    case 'IMAX':
        $PrecioBase = 85;
        break;
    case 'VIP':
        $PrecioBase = 105;
        break;
    default:
        $PrecioBase = 0;
        break;
}

//Determinar el Descuento
$Descuento = 0;

if ($Estudiante) {
    $Descuento = 0.15; // 15%
} elseif ($Edad <= 12) {
    $Descuento = 0.20; // 20%
} elseif ($Edad >= 65) {
    $Descuento = 0.25; // 25%
}

//Calcular Total con Descuento
$DescuentoAplicado = $PrecioBase * $Descuento;
$TotalPagar = $PrecioBase - $DescuentoAplicado;
?>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8" />
    <title>Ticket CineClub</title>
    <style>
        /*Fondo general*/
        body {
            background-color: #F2EFE8; /* Fondo */
            font-family: Georgia, serif; /* Tipo de letra */
            display: flex; /* Centro */
            justify-content: center; /* Horizontal */
            align-items: center; /* Vertical */
            height: 100vh; /* Alto total */
        }

        /*Contenedor del Ticket*/
        .ticket {
            background-color: #E0DED5; /* Color del Cuadro */
            padding: 30px; /* Espaciado Interno */
            width: 400px; /* Ancho fijo */
            text-align: center; /* Centrar texto */
        }

        /*Imagen del logo*/
        .ticket img {
            width: 100px; /* Tamaño */
            height: 100px;
            border-radius: 50%; /* Circular */
            object-fit: cover; /* Ajuste */
            margin-bottom: 1px; /* Separación */
        }

        /*Título*/
        .ticket h2 {
            margin-bottom: 1px; /* Separación abajo */
        }

        /*Texto general*/
        .ticket p {
            margin: 10px 0; /* Márgenes */
        }
    </style>
</head>
<body>

    <div class="ticket">
        <!--Logo de CineClub--> 
        <img src="CineClub.png" alt="Logo CineClub" />

        <!--Título del Ticket-->
        <h2>Tu Ticket de CineClub</h2>

        <!--Mostrar datos del usuario-->
        <p><strong>Nombre:</strong> <?php echo htmlspecialchars($Nombre); ?></p>
        <p><strong>Edad:</strong> <?php echo htmlspecialchars($Edad); ?> Años</p>
        <p><strong>Función:</strong> <?php echo htmlspecialchars($Funcion); ?></p>
        <!--Mostrar Descuento Aplicado-->
        <p><strong>Descuento Aplicado:</strong>
            <?php
                if ($Descuento == 0.15) echo "15% (Estudiante)";
                elseif ($Descuento == 0.20) echo "20% (Niño)";
                elseif ($Descuento == 0.25) echo "25% (Adulto Mayor)";
                else echo "Sin descuento";
            ?>
        </p>
<br>
        <!-- Total a pagar-->
        <p><strong>Total a Pagar:</strong> $<?php echo number_format($TotalPagar, 2); ?> MXN</p>
    </div>

</body>
</html>