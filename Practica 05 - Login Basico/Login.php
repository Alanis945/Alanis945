<?php
// Obtener datos del formulario con seguridad por si no vienen
$usuario = $_POST['usuario'] ?? '';
$clave = $_POST['clave'] ?? '';

// Configurar estilos base para el body y cuadro blanco en variable
function mostrarMensaje($fondoColor, $titulo, $imagen) {
    echo '<body style="background-color: '.$fondoColor.'; margin:0; display:flex; justify-content:center; align-items:center; height:100vh;">';
    echo '<div style="background-color: white; padding: 20px; border-radius: 8px; text-align:center; width: 300px;">';
    echo '<h1 style="font-family: Arial, sans-serif; font-weight: bold;">'.$titulo.'</h1>';
    echo '<img src="'.$imagen.'" alt="'.$titulo.'" style="width:300px; margin-top: 15px;">';
    echo '</div></body>';
}

if ($usuario === 'admin' && $clave === 'admin') {
    mostrarMensaje('green', 'ACCESO CONCEDIDO', 'AccessGranted.png');
} else {
    mostrarMensaje('red', 'ACCESO DENEGADO', 'AccessDenied.png');
}
?>