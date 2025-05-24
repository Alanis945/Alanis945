<!DOCTYPE html>
<html lang="es">
<head>
  <meta charset="UTF-8">
  <title>Resultado</title>
  <style>
    body {
      background-color: gray;
      font-family: Arial, sans-serif;
      display: flex;
      justify-content: center;
      align-items: center;
      height: 100vh;
      margin: 0;
    }

    .resultado {
      background-color:rgb(0, 0, 0); /* azul fuerte */
      color: white;
      padding: 30px;
      border-radius: 15px;
      box-shadow: 0 0 15px rgba(0, 0, 0, 0.3);
      text-align: center;
      width: 300px;
    }

    .boton-volver {
      display: inline-block;
      margin-top: 20px;
      padding: 10px 20px;
      background-color: white;
      color:rgb(0, 0, 0);
      text-decoration: none;
      font-weight: bold;
      border-radius: 5px;
      transition: background 0.3s ease;
    }

    .boton-volver:hover {
      background-color: #e0e0e0;
    }
  </style>
</head>
<body>

  <div class="resultado">
    <?php
    // Obtener los valores del formulario
    $num1 = $_GET['num1'];
    $num2 = $_GET['num2'];
    $operacion = $_GET['operacion'];
    $resultado = 0;

    // Realizar la operación
    switch ($operacion) {
      case 'Sumar':
        $resultado = $num1 + $num2;
        break;
      case 'Restar':
        $resultado = $num1 - $num2;
        break;
      case 'Multiplicar':
        $resultado = $num1 * $num2;
        break;
      case 'Dividir':
        if ($num2 != 0) {
          $resultado = $num1 / $num2;
        } else {
          $resultado = "Error: No se Puede Dividir por Cero.";
        }
        break;
      default:
        $resultado = "Operación no Válida.";
    }

    // Mostrar el resultado
    echo "<h2>Resultado:</h2>";
    echo "<p><strong>$resultado</strong></p>";
    ?>
    <a class="boton-volver" href="Calculadora.html">Volver</a>
  </div>

</body>
</html>