using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convetidor_de_Video
{
    class Convertidor
    {
        //Ruta del archivo de video
        public string OpenFilePath { get; set; }
        //Extension del archivo de video
        public string Extension { get; set; }
        //Archivo de video
        public MediaFile VideoFile { get; set; }
        //Herramienta para obtener los datos del video
        public Engine VideoEngine { get; set; }
        //Tiempo que dura el video
        public double Duration { get; set; }
        //Extensión a la que se convertirá el video
        public string NewExtension { get; set; }
        //Tiempo de inicio donde se recortará el video
        public double StartTimeCut { get; set; }
        //Tiempo que durará el video que recortaremos
        public double DurationCut { get; set; }
        //Grados en los que se rotará el video
        public int RotationDegrees { get; set; }
        //Opcion para descargar el audio
        public bool DownloadAudio { get; set; }

        public Convertidor()
        {
            this.VideoEngine = new Engine();
        }

        public void setMetaData()
        {
            this.VideoEngine.GetMetadata(this.VideoFile);
        }

        public void setDuration()
        {
            this.Duration=this.VideoFile.Metadata.Duration.Seconds;
        }

    }
}
