using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
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
        public VideoSize SizeVideo { get; set; }
        //Opcion para descargar el audio
        public int Fps { get; set; }
        //Nombre del nuevo video
        public string SaveFilePath { get; set; }
        //Conversion Options
        public ConversionOptions Option { get; set; }

        public Convertidor()
        {
            this.OpenFilePath = "";
            this.Extension = "";
            this.VideoFile = null;
            this.Duration = 0;
            this.NewExtension = "";
            this.StartTimeCut = 0;
            this.DurationCut = 0;
            this.VideoEngine = new Engine();
            this.Option = new ConversionOptions();
        }

        public void setMetaData()
        {
            this.VideoEngine.GetMetadata(this.VideoFile);
        }

        public void setDuration()
        {
            this.Duration = this.VideoFile.Metadata.Duration.Seconds;
        }

        public void convertVideo()
        {
            if(this.StartTimeCut!=0 && this.DurationCut != 0)
            {
                this.Option.CutMedia(TimeSpan.FromSeconds(this.StartTimeCut), TimeSpan.FromSeconds(this.DurationCut));
                this.Option.VideoSize = this.SizeVideo;
                this.Option.VideoFps = this.Fps;
                MediaFile inputFile = new MediaFile(this.OpenFilePath);
                MediaFile outputFile = new MediaFile(this.SaveFilePath);
                this.VideoEngine.Convert(inputFile, outputFile, this.Option);
            }

        }

        public string toString()
        {
            return "File path: " + this.OpenFilePath + "\n" +
                "Extension: " + this.Extension + "\n" +
                "Duration: " + this.Duration + "\n" +
                "New Extension: " + this.NewExtension + "\n" +
                "Start Time Cut: " + this.StartTimeCut + "\n" +
                "Duration Cut: " + this.DurationCut + "\n" +
                "SaveFile Path: "+this.SaveFilePath;

        }
    }
}
