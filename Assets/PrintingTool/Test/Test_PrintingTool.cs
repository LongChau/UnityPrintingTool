using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class Test_PrintingTool : MonoBehaviour {

    public string filePath = "";

    public PrintingTool printingTool;

    public TMP_InputField printerNameInput;
    public TMP_InputField imagePathInput;
    public Button btnPrint;

    void Start()
    {
        printerNameInput.onEndEdit.AddListener(Handle_printerNameInput_onEndEdit);
        imagePathInput.onEndEdit.AddListener(Handle_imagePathInput_onEndEdit);
        btnPrint.onClick.AddListener(Print);
    }

    private void Handle_imagePathInput_onEndEdit(string input)
    {
        filePath = input;
    }

    private void Handle_printerNameInput_onEndEdit(string input)
    {
        printingTool.printerName = input;
    }

    public void Print()
    {
        printingTool.CmdPrintThreaded(filePath);
        printingTool.StartCheckIsPrintingDone();
    }
}
