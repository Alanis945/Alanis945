<?php
// Obtener el nombre de la imagen desde la URL usando $_GET
// Si no se recibe nada, se usa una imagen por defecto (1.jpg)
$imagen = $_GET['img'] ?? '1.jpg';
?>

<!DOCTYPE html>
<html lang="es">
<head>
  <meta charset="UTF-8">
  <title>Galería Jurassic Park III</title>
  <style>
    body {
      font-family: sans-serif;
      text-align: center;

      background-image: url(huesos.jpeg);
      background-size: cover;
      background-position: center;
      background-repeat: no-repeat;
      background-attachment: fixed;
      color: white;
      text-shadow: 1px 1px 4px black;
    }
    /* Aquí puedes mantener los estilos para la galería */
  </style>

  <style>
    /* Estilo general */
    body {
      font-family: sans-serif;
      text-align: center;
    }

    /* Imagen grande */
    img {
      width: 80%;
      max-width: 800px;
      margin-top: 30px;
      border: 3px solid #333;
      border-radius: 10px;
    }

    /* Botón para volver a la galería */
    a {
      display: inline-block;
      margin-top: 20px;
      text-decoration: none;
      background: #333;
      color: #fff;
      padding: 10px 20px;
      border-radius: 8px;
    }
  </style>
</head>
<body>

  <h1>Imagen en Grande</h1>

  <!-- Mostrar la imagen que se pasó por parámetro -->
  <img src="<?php echo htmlspecialchars($imagen); ?>" alt="Imagen en Grande">

  <!-- Botón para regresar a la galería -->
  <br>
  <a href="galeria.html">Volver a Galería</a>
