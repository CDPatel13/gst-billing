using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
public class Logger
{    
    String fileName, fileSuffix, log;
    FileInfo fInfo;
    long maxFileSize=50*1024*1024;
    int year, month, date;
    public Logger(String fileName)
    {
        this.fileName = fileName;
        year = System.DateTime.Now.Year;
        month = System.DateTime.Now.Month;
        date = System.DateTime.Now.Day;
        fileSuffix = year+"";
        if (month < 10)
        {
            fileSuffix += "0" ;
        }

        fileSuffix += month;
        if (date < 10)
        {
            fileSuffix += "0";
        }

        fileSuffix += date;
        this.fileName=fileName+fileSuffix+".log";
        if(File.Exists("|DataDirectory|/"+this.fileName)){
            fInfo = new FileInfo("|DataDirectory|/" + this.fileName);
            if (fInfo.Length > maxFileSize)
            {
                File.Create("|DataDirectory|/" + this.fileName + "_2");
                fInfo = new FileInfo("|DataDirectory|/" + this.fileName + "_2");
                this.fileName = fInfo.FullName;
            }
        }
    }
    public void writeLog(String log)
    {
        this.log = log;
        File.AppendAllText(this.fileName, this.log+Environment.NewLine);
        
    }
    
}

