# Reproductor Multimedia en C# con Interfaz Gráfica

![image](https://github.com/user-attachments/assets/9f28459f-7827-430a-b363-93e11ff6eda1)

![image](https://github.com/user-attachments/assets/9fcaed7f-b391-43d6-90c4-a2cd1bc55250)

![image](https://github.com/user-attachments/assets/f7efcc87-ecf9-44f6-90f1-a1c77622d79d)

Este proyecto es un reproductor multimedia básico desarrollado en C# utilizando Windows Forms con Visual Studio 2022. Permite a los usuarios abrir y reproducir archivos de audio y video compatibles con Windows Media Player.

## Características Principales

* **Abrir Archivos:** Permite seleccionar archivos multimedia desde el sistema utilizando un cuadro de diálogo.
* **Reproducir/Pausar:** Control para iniciar y detener temporalmente la reproducción.
* **(Opcional) Detener:** Detiene completamente la reproducción y vuelve al inicio.
* **(Opcional) Control de Volumen:** Ajuste del volumen de reproducción mediante un `TrackBar`.
* **(Opcional) Barra de Progreso:** Visualización y control de la posición de reproducción.
* **(Opcional) Visualización del Tiempo:** Muestra el tiempo de reproducción actual y total.

## Requisitos del Sistema

* **Sistema Operativo:** Windows (compatible con .NET Framework o .NET).
* **Visual Studio 2022:** Instalado con las cargas de trabajo de desarrollo de .NET y desarrollo de escritorio con C#.

## Cómo Utilizar

1.  **Clonar o Descargar el Proyecto:**
    * Si el código está en un repositorio (por ejemplo, GitHub), clónalo a tu máquina local.
    * Si recibiste los archivos directamente, guárdalos en una carpeta.

2.  **Abrir el Proyecto en Visual Studio 2022:**
    * Abre Visual Studio 2022.
    * Selecciona "Abrir un proyecto o solución".
    * Navega hasta la carpeta donde guardaste el proyecto y selecciona el archivo de la solución (`.sln`).

3.  **Compilar y Ejecutar:**
    * Una vez que el proyecto se haya cargado, ve a "Compilar" > "Compilar solución" en la barra de menú.
    * Si la compilación es exitosa, ve a "Depurar" > "Iniciar depuración" (o presiona F5) para ejecutar la aplicación.

4.  **Interactuar con el Reproductor:**
    * Haz clic en el botón "Abrir Archivo" para seleccionar un archivo de audio o video desde tu computadora.
    * Utiliza el botón "Reproducir/Pausar" para controlar la reproducción.
    * **(Si está implementado)** Ajusta el volumen utilizando el `TrackBar` de volumen.
    * **(Si está implementado)** Observa el progreso de la reproducción en la barra de progreso y puedes hacer clic en ella para saltar a diferentes puntos del archivo.
    * **(Si está implementado)** El tiempo de reproducción actual y total se mostrará en la etiqueta correspondiente.

## Estructura del Proyecto

El proyecto típicamente tendrá la siguiente estructura:

* **`[NombreDelProyecto].sln`:** Archivo de la solución de Visual Studio.
* **`[NombreDelProyecto].csproj`:** Archivo del proyecto de C#.
* **`Form1.cs`:** Archivo de código C# para la ventana principal del reproductor. Contiene la lógica de la aplicación y los controladores de eventos.
* **`Form1.Designer.cs`:** Archivo generado automáticamente por Visual Studio que contiene el código para el diseño de la interfaz gráfica (controles,布局, etc.).
* **`Form1.resx`:** Archivo de recursos para el formulario (por ejemplo, cadenas de texto, imágenes).
* **`Program.cs`:** Punto de entrada principal de la aplicación.
* **`Properties/`:** Carpeta que contiene archivos de configuración del proyecto (por ejemplo, `AssemblyInfo.cs`, `Settings.settings`, `Resources.resx`).


## copyright (c) [Año] [Tu Nombre o Nombre de la Organización]
## Todos los derechos reservados.

Este software se proporciona "TAL CUAL", sin garantía de ningún tipo, expresa o implícita, incluyendo, pero no limitado a, las garantías de comerciabilidad, idoneidad para un propósito particular y no infracción. En ningún caso, el autor o los titulares de los derechos de autor serán responsables de ninguna reclamación, daño u otra responsabilidad, ya sea en una acción de contrato, agravio o de otro modo, que surja de, fuera de o en conexión con el software o el uso u otros tratos en el software.

## Código Fuente (Ejemplos)

A continuación, se muestran fragmentos de código clave del archivo `Form1.cs`:

```csharp
// Evento Click del botón "Abrir Archivo"
private void btnAbrir_Click(object sender, EventArgs e)
{
    if (dialogoAbrir.ShowDialog() == DialogResult.OK)
    {
        reproductor.URL = dialogoAbrir.FileName;
        // Opcional: Mostrar el nombre del archivo
        // lblNombreArchivo.Text = dialogoAbrir.SafeFileName;
    }
}

// Evento Click del botón "Reproducir/Pausar"
private void btnReproducir_Click(object sender, EventArgs e)
{
    if (reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
    {
        reproductor.Ctlcontrols.pause();
        btnReproducir.Text = "Reproducir";
    }
    else
    {
        reproductor.Ctlcontrols.play();
        btnReproducir.Text = "Pausar";
    }
}

// (Ejemplo opcional) Evento Scroll del TrackBar de Volumen
private void barraVolumen_Scroll(object sender, EventArgs e)
{
    reproductor.settings.volume = barraVolumen.Value;
}
