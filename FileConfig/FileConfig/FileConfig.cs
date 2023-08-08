using System;
using System.IO;
using System.Reflection;
using System.Xml;

public class FileConfig
{
    //VARIABILI INTERNE
    private string _FileName, _LocalPath,
                   _Key = "Var0",
                   _Session = "Session_0",
                   _Value = "Empty";

    //COSTUTTORI
    public FileConfig()   //Costruttore di DEFAULT
    {
        _LocalPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        _FileName = "App.config";
    }

    //PROPRIETA'
    public string LocalPath      //Percorso del file
    {
        get { return _LocalPath; }
        set { _LocalPath = value; }
    }

    public string NameFile  //Nome file
    {
        get { return _FileName; }
        set { _FileName = value; }
    }

    public string Session   //Nome della sessione
    {
        get { return _Session; }
        set { _Session = value; }
    }

    public string Key       //Nome chiave
    {
        get { return _Key; }
        set { _Key = value; }
    }

    public string Value       //Valore della variabile
    {
        get { return _Value; }
        set { _Value = value; }
    }

    /// <summary>
    /// Lettura di un valore nel file .config
    /// </summary>
    /// <returns></returns>
    public string Read()
    {
        return _Read(_LocalPath, _FileName, _Session, _Key);
    }

    /// <summary>
    /// Lettura di un valore nel file .config specificando la Chiave
    /// </summary>
    /// <returns></returns>
    public string Read(string Key)
    {
        return _Read(_LocalPath, _FileName, _Session, Key);
    }

    /// <summary>
    /// Lettura di un valore nel file .config specificando la Sessione e la Chiave
    /// </summary>
    /// <returns></returns>
    public string Read(string Session, string Key)
    {
        return _Read(_LocalPath, _FileName, Session, Key);
    }

    /// <summary>
    /// Preleva l'esistenza di una Sessione.
    /// Ritorna TRUE se ESISTE Altrimenti FALSE se non ESISTE
    /// </summary>
    /// <returns></returns>
    public bool GetSession()
    {
        return GetSession(_Session);
    }

    public bool GetSession(string Session)
    {
        bool ret = false;

        // Carica il file di configurazione
        XmlDocument File = loadFile(_LocalPath + "\\" + _FileName);

        // Punta alla singola sezione
        XmlNode node = File.SelectSingleNode("//" + _Session);

        if (node != null)
        {
            ret = true;
        }

        return ret;
    }

    /// <summary>
    /// Scrittura di un valore nel file .config
    /// </summary>
    /// <returns></returns>
    public void Write()
    {
        _Write(_Value);
    }

    /// <summary>
    /// Scrittura di un valore nel file .config specificando solo il valore
    /// </summary>
    /// <returns></returns
    public void Write(string Value)
    {
        _Write(Value);
    }

    /// <summary>
    /// Scrittura di un valore nel file .config specificando la Chiave
    /// </summary>
    /// <returns></returns
    public void Write(string Key, string Value)
    {
        _Session = Session;
        _Key = Key;
        _Write(Value);
    }

    /// <summary>
    /// Scrittura di un valore nel file .config specificando la Sessione e la Chiave
    /// </summary>
    /// <returns></returns
    public void Write(string Session, string Key, string Value)
    {
        _Session = Session;
        _Key = Key;
        _Write(Value);
    }

    //METODI
    private string _Read(string _LocalPath, string _FileName, string _Session, string _key)
    {
        string str = "";

        // Carica il file di configurazione
        XmlDocument File = loadFile(_LocalPath + "\\" + _FileName);

        // Punta alla singola sezione
        XmlNode node = File.SelectSingleNode("//" + _Session);

        if (node == null)
        {
            throw new InvalidOperationException(_Session + " section not found in config file.");
        }

        try
        {
            // select the 'add' element that contains the key
            XmlElement elem = (XmlElement)node.SelectSingleNode(string.Format("//add[@key='{0}']", _key));

            if (elem != null)
            {
                str = elem.GetAttribute("value");
            }
            else
            {
                throw new InvalidOperationException("Elemento non trovato.");
            }
        }
        catch
        {
            throw;
        }
        return str;
    }

    private void _Write(string value)
    {
        // Carica il File
        XmlDocument doc = loadFile(_LocalPath + "\\" + _FileName);

        // retrieve appSettings node
        XmlNode node = doc.SelectSingleNode("//" + _Session);

        if (node == null)
            throw new InvalidOperationException("appSettings section not found in config file.");

        try
        {
            // select the 'add' element that contains the key
            XmlElement elem = (XmlElement)node.SelectSingleNode(string.Format("//add[@key='{0}']", _Key));

            if (elem != null)
            {
                // add value for key
                elem.SetAttribute("value", value);
            }
            else
            {
                // key was not found so create the 'add' element 
                // and set it's key/value attributes 
                elem = doc.CreateElement("add");
                elem.SetAttribute("key", _Key);
                elem.SetAttribute("value", value);
                node.AppendChild(elem);
            }
            doc.Save(_LocalPath + "\\" + _FileName);
        }
        catch
        {
            throw;
        }
    }

    private void RemoveSetting()
    {
        // load config document for current assembly
        XmlDocument doc = loadFile(_LocalPath + "\\" + _FileName);

        // retrieve appSettings node
        XmlNode node = doc.SelectSingleNode("\\" + _Session);

        try
        {
            if (node == null)
                throw new InvalidOperationException("appSettings section not found in config file.");
            else
            {
                // remove 'add' element with coresponding key
                node.RemoveChild(node.SelectSingleNode(string.Format("//add[@key='{0}']", _Key)));
                doc.Save(_LocalPath);
            }
        }
        catch (NullReferenceException e)
        {
            throw new Exception(string.Format("The key {0} does not exist.", _Key), e);
        }
    }

    private static XmlDocument loadFile(string url)
    {
        XmlDocument doc = null;
        try
        {
            doc = new XmlDocument();
            //doc.Load(getFileLocalPath());
            doc.Load(url);
            return doc;
        }
        catch (System.IO.FileNotFoundException e)
        {
            throw new Exception("Configuration file found not found.", e);
        }
    }
}
