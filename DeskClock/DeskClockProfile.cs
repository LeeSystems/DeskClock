﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.9151
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/DeskClockProfile.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/DeskClockProfile.xsd", IsNullable=false)]
public partial class DeskClockProfile {
    
    private DeskClockProfileWindowPosition windowPositionField;
    
    private DeskClockProfileTimeDisplay timeDisplayField;
    
    private DeskClockProfileSecondsBar secondsBarField;
    
    private string nameField;
    
    private bool allwaysOnTopField;
    
    private bool allwaysOnTopFieldSpecified;
    
    /// <remarks/>
    public DeskClockProfileWindowPosition WindowPosition {
        get {
            return this.windowPositionField;
        }
        set {
            this.windowPositionField = value;
        }
    }
    
    /// <remarks/>
    public DeskClockProfileTimeDisplay TimeDisplay {
        get {
            return this.timeDisplayField;
        }
        set {
            this.timeDisplayField = value;
        }
    }
    
    /// <remarks/>
    public DeskClockProfileSecondsBar SecondsBar {
        get {
            return this.secondsBarField;
        }
        set {
            this.secondsBarField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool AllwaysOnTop {
        get {
            return this.allwaysOnTopField;
        }
        set {
            this.allwaysOnTopField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AllwaysOnTopSpecified {
        get {
            return this.allwaysOnTopFieldSpecified;
        }
        set {
            this.allwaysOnTopFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/DeskClockProfile.xsd")]
public partial class DeskClockProfileWindowPosition {
    
    private double horizontalField;
    
    private double verticalField;
    
    /// <remarks/>
    public double Horizontal {
        get {
            return this.horizontalField;
        }
        set {
            this.horizontalField = value;
        }
    }
    
    /// <remarks/>
    public double Vertical {
        get {
            return this.verticalField;
        }
        set {
            this.verticalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/DeskClockProfile.xsd")]
public partial class DeskClockProfileTimeDisplay {
    
    private string timeZoneField;
    
    private double titleFountSizeField;
    
    private bool titleEnableField;
    
    private double dateFountSizeField;
    
    private bool dateEnableField;
    
    private double clockFountSizeField;
    
    private string forgroundColorField;
    
    private string backgroundColorField;
    
    /// <remarks/>
    public string TimeZone {
        get {
            return this.timeZoneField;
        }
        set {
            this.timeZoneField = value;
        }
    }
    
    /// <remarks/>
    public double TitleFountSize {
        get {
            return this.titleFountSizeField;
        }
        set {
            this.titleFountSizeField = value;
        }
    }
    
    /// <remarks/>
    public bool TitleEnable {
        get {
            return this.titleEnableField;
        }
        set {
            this.titleEnableField = value;
        }
    }
    
    /// <remarks/>
    public double DateFountSize {
        get {
            return this.dateFountSizeField;
        }
        set {
            this.dateFountSizeField = value;
        }
    }
    
    /// <remarks/>
    public bool DateEnable {
        get {
            return this.dateEnableField;
        }
        set {
            this.dateEnableField = value;
        }
    }
    
    /// <remarks/>
    public double ClockFountSize {
        get {
            return this.clockFountSizeField;
        }
        set {
            this.clockFountSizeField = value;
        }
    }
    
    /// <remarks/>
    public string ForgroundColor {
        get {
            return this.forgroundColorField;
        }
        set {
            this.forgroundColorField = value;
        }
    }
    
    /// <remarks/>
    public string BackgroundColor {
        get {
            return this.backgroundColorField;
        }
        set {
            this.backgroundColorField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/DeskClockProfile.xsd")]
public partial class DeskClockProfileSecondsBar {
    
    private bool visableField;
    
    private bool highlightEnableField;
    
    private int higlightAfterField;
    
    private int barHeightField;
    
    private string backgroundColorField;
    
    private string forgroundColorField;
    
    private string highlightColorField;
    
    /// <remarks/>
    public bool Visable {
        get {
            return this.visableField;
        }
        set {
            this.visableField = value;
        }
    }
    
    /// <remarks/>
    public bool HighlightEnable {
        get {
            return this.highlightEnableField;
        }
        set {
            this.highlightEnableField = value;
        }
    }
    
    /// <remarks/>
    public int HiglightAfter {
        get {
            return this.higlightAfterField;
        }
        set {
            this.higlightAfterField = value;
        }
    }
    
    /// <remarks/>
    public int BarHeight {
        get {
            return this.barHeightField;
        }
        set {
            this.barHeightField = value;
        }
    }
    
    /// <remarks/>
    public string BackgroundColor {
        get {
            return this.backgroundColorField;
        }
        set {
            this.backgroundColorField = value;
        }
    }
    
    /// <remarks/>
    public string ForgroundColor {
        get {
            return this.forgroundColorField;
        }
        set {
            this.forgroundColorField = value;
        }
    }
    
    /// <remarks/>
    public string HighlightColor {
        get {
            return this.highlightColorField;
        }
        set {
            this.highlightColorField = value;
        }
    }
}