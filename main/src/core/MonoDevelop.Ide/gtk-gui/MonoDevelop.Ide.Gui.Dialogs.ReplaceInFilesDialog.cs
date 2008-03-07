// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.Dialogs {
    
    
    internal partial class ReplaceInFilesDialog {
        
        private Gtk.VBox vbox15;
        
        private Gtk.Table table2;
        
        private Gtk.Button browseButton;
        
        private Gtk.Entry directoryTextBox;
        
        private Gtk.Entry fileMaskTextBox;
        
        private Gtk.Button findHelpButton;
        
        private Gtk.Label label1;
        
        private Gtk.Label label6;
        
        private Gtk.Label label7;
        
        private Gtk.Label labelReplace;
        
        private Gtk.Button replaceHelpButton;
        
        private Gtk.ComboBoxEntry replacePatternEntry;
        
        private Gtk.ComboBoxEntry searchPatternEntry;
        
        private Gtk.CheckButton includeSubdirectoriesCheckBox;
        
        private Gtk.CheckButton ignoreCaseCheckBox;
        
        private Gtk.CheckButton searchWholeWordOnlyCheckBox;
        
        private Gtk.HBox hbox16;
        
        private Gtk.CheckButton useSpecialSearchStrategyCheckBox;
        
        private Gtk.ComboBox specialSearchStrategyComboBox;
        
        private Gtk.HBox hbox17;
        
        private Gtk.Label searchLocationLabel;
        
        private Gtk.ComboBox searchLocationComboBox;
        
        private Gtk.Button stopButton;
        
        private Gtk.Button closeButton;
        
        private Gtk.Button replaceAllButton;
        
        private Gtk.Button findButton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.Gui.Dialogs.ReplaceInFilesDialog
            this.Name = "MonoDevelop.Ide.Gui.Dialogs.ReplaceInFilesDialog";
            this.Title = "Replace in Files";
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.BorderWidth = ((uint)(6));
            this.DestroyWithParent = true;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.ReplaceInFilesDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog-vbox2";
            w1.Spacing = 6;
            w1.BorderWidth = ((uint)(2));
            // Container child dialog-vbox2.Gtk.Box+BoxChild
            this.vbox15 = new Gtk.VBox();
            this.vbox15.Name = "vbox15";
            this.vbox15.Spacing = 6;
            this.vbox15.BorderWidth = ((uint)(6));
            // Container child vbox15.Gtk.Box+BoxChild
            this.table2 = new Gtk.Table(((uint)(4)), ((uint)(3)), false);
            this.table2.Name = "table2";
            this.table2.RowSpacing = ((uint)(6));
            this.table2.ColumnSpacing = ((uint)(6));
            // Container child table2.Gtk.Table+TableChild
            this.browseButton = new Gtk.Button();
            this.browseButton.Name = "browseButton";
            this.browseButton.UseUnderline = true;
            this.browseButton.Label = "...";
            this.table2.Add(this.browseButton);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table2[this.browseButton]));
            w2.TopAttach = ((uint)(3));
            w2.BottomAttach = ((uint)(4));
            w2.LeftAttach = ((uint)(2));
            w2.RightAttach = ((uint)(3));
            w2.XOptions = ((Gtk.AttachOptions)(4));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.directoryTextBox = new Gtk.Entry();
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.IsEditable = true;
            this.directoryTextBox.ActivatesDefault = true;
            this.directoryTextBox.InvisibleChar = '●';
            this.table2.Add(this.directoryTextBox);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table2[this.directoryTextBox]));
            w3.TopAttach = ((uint)(3));
            w3.BottomAttach = ((uint)(4));
            w3.LeftAttach = ((uint)(1));
            w3.RightAttach = ((uint)(2));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.fileMaskTextBox = new Gtk.Entry();
            this.fileMaskTextBox.Name = "fileMaskTextBox";
            this.fileMaskTextBox.IsEditable = true;
            this.fileMaskTextBox.ActivatesDefault = true;
            this.fileMaskTextBox.InvisibleChar = '●';
            this.table2.Add(this.fileMaskTextBox);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table2[this.fileMaskTextBox]));
            w4.TopAttach = ((uint)(2));
            w4.BottomAttach = ((uint)(3));
            w4.LeftAttach = ((uint)(1));
            w4.RightAttach = ((uint)(2));
            w4.XOptions = ((Gtk.AttachOptions)(4));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.findHelpButton = new Gtk.Button();
            this.findHelpButton.Name = "findHelpButton";
            this.findHelpButton.UseUnderline = true;
            this.findHelpButton.Label = ">";
            this.table2.Add(this.findHelpButton);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table2[this.findHelpButton]));
            w5.LeftAttach = ((uint)(2));
            w5.RightAttach = ((uint)(3));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Find:");
            this.table2.Add(this.label1);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table2[this.label1]));
            w6.XOptions = ((Gtk.AttachOptions)(4));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.Xalign = 0F;
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("Filemask:");
            this.table2.Add(this.label6);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table2[this.label6]));
            w7.TopAttach = ((uint)(2));
            w7.BottomAttach = ((uint)(3));
            w7.XOptions = ((Gtk.AttachOptions)(4));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.Xalign = 0F;
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("Directory:");
            this.table2.Add(this.label7);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.table2[this.label7]));
            w8.TopAttach = ((uint)(3));
            w8.BottomAttach = ((uint)(4));
            w8.XOptions = ((Gtk.AttachOptions)(4));
            w8.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.labelReplace = new Gtk.Label();
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Xalign = 0F;
            this.labelReplace.LabelProp = Mono.Unix.Catalog.GetString("Replace:");
            this.table2.Add(this.labelReplace);
            Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table2[this.labelReplace]));
            w9.TopAttach = ((uint)(1));
            w9.BottomAttach = ((uint)(2));
            w9.XOptions = ((Gtk.AttachOptions)(4));
            w9.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.replaceHelpButton = new Gtk.Button();
            this.replaceHelpButton.Name = "replaceHelpButton";
            this.replaceHelpButton.UseUnderline = true;
            this.replaceHelpButton.Label = ">";
            this.table2.Add(this.replaceHelpButton);
            Gtk.Table.TableChild w10 = ((Gtk.Table.TableChild)(this.table2[this.replaceHelpButton]));
            w10.TopAttach = ((uint)(1));
            w10.BottomAttach = ((uint)(2));
            w10.LeftAttach = ((uint)(2));
            w10.RightAttach = ((uint)(3));
            w10.XOptions = ((Gtk.AttachOptions)(4));
            w10.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.replacePatternEntry = new Gtk.ComboBoxEntry();
            this.replacePatternEntry.Name = "replacePatternEntry";
            this.table2.Add(this.replacePatternEntry);
            Gtk.Table.TableChild w11 = ((Gtk.Table.TableChild)(this.table2[this.replacePatternEntry]));
            w11.TopAttach = ((uint)(1));
            w11.BottomAttach = ((uint)(2));
            w11.LeftAttach = ((uint)(1));
            w11.RightAttach = ((uint)(2));
            w11.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.searchPatternEntry = new Gtk.ComboBoxEntry();
            this.searchPatternEntry.Name = "searchPatternEntry";
            this.table2.Add(this.searchPatternEntry);
            Gtk.Table.TableChild w12 = ((Gtk.Table.TableChild)(this.table2[this.searchPatternEntry]));
            w12.LeftAttach = ((uint)(1));
            w12.RightAttach = ((uint)(2));
            w12.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox15.Add(this.table2);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.vbox15[this.table2]));
            w13.Position = 0;
            w13.Expand = false;
            w13.Fill = false;
            // Container child vbox15.Gtk.Box+BoxChild
            this.includeSubdirectoriesCheckBox = new Gtk.CheckButton();
            this.includeSubdirectoriesCheckBox.Name = "includeSubdirectoriesCheckBox";
            this.includeSubdirectoriesCheckBox.Label = Mono.Unix.Catalog.GetString("Recurse subdirectories");
            this.includeSubdirectoriesCheckBox.DrawIndicator = true;
            this.includeSubdirectoriesCheckBox.UseUnderline = true;
            this.vbox15.Add(this.includeSubdirectoriesCheckBox);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox15[this.includeSubdirectoriesCheckBox]));
            w14.Position = 1;
            w14.Expand = false;
            w14.Fill = false;
            // Container child vbox15.Gtk.Box+BoxChild
            this.ignoreCaseCheckBox = new Gtk.CheckButton();
            this.ignoreCaseCheckBox.Name = "ignoreCaseCheckBox";
            this.ignoreCaseCheckBox.Label = Mono.Unix.Catalog.GetString("Case sensitive");
            this.ignoreCaseCheckBox.DrawIndicator = true;
            this.ignoreCaseCheckBox.UseUnderline = true;
            this.vbox15.Add(this.ignoreCaseCheckBox);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox15[this.ignoreCaseCheckBox]));
            w15.Position = 2;
            w15.Expand = false;
            // Container child vbox15.Gtk.Box+BoxChild
            this.searchWholeWordOnlyCheckBox = new Gtk.CheckButton();
            this.searchWholeWordOnlyCheckBox.Name = "searchWholeWordOnlyCheckBox";
            this.searchWholeWordOnlyCheckBox.Label = Mono.Unix.Catalog.GetString("Whole word only");
            this.searchWholeWordOnlyCheckBox.DrawIndicator = true;
            this.searchWholeWordOnlyCheckBox.UseUnderline = true;
            this.vbox15.Add(this.searchWholeWordOnlyCheckBox);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox15[this.searchWholeWordOnlyCheckBox]));
            w16.Position = 3;
            w16.Expand = false;
            // Container child vbox15.Gtk.Box+BoxChild
            this.hbox16 = new Gtk.HBox();
            this.hbox16.Name = "hbox16";
            this.hbox16.Spacing = 6;
            // Container child hbox16.Gtk.Box+BoxChild
            this.useSpecialSearchStrategyCheckBox = new Gtk.CheckButton();
            this.useSpecialSearchStrategyCheckBox.Name = "useSpecialSearchStrategyCheckBox";
            this.useSpecialSearchStrategyCheckBox.Label = Mono.Unix.Catalog.GetString("Use special search strategy:");
            this.useSpecialSearchStrategyCheckBox.DrawIndicator = true;
            this.useSpecialSearchStrategyCheckBox.UseUnderline = true;
            this.hbox16.Add(this.useSpecialSearchStrategyCheckBox);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.hbox16[this.useSpecialSearchStrategyCheckBox]));
            w17.Position = 0;
            w17.Expand = false;
            // Container child hbox16.Gtk.Box+BoxChild
            this.specialSearchStrategyComboBox = new Gtk.ComboBox();
            this.specialSearchStrategyComboBox.Name = "specialSearchStrategyComboBox";
            this.hbox16.Add(this.specialSearchStrategyComboBox);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.hbox16[this.specialSearchStrategyComboBox]));
            w18.Position = 1;
            this.vbox15.Add(this.hbox16);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.vbox15[this.hbox16]));
            w19.Position = 4;
            w19.Expand = false;
            w19.Fill = false;
            // Container child vbox15.Gtk.Box+BoxChild
            this.hbox17 = new Gtk.HBox();
            this.hbox17.Name = "hbox17";
            this.hbox17.Spacing = 6;
            // Container child hbox17.Gtk.Box+BoxChild
            this.searchLocationLabel = new Gtk.Label();
            this.searchLocationLabel.Name = "searchLocationLabel";
            this.searchLocationLabel.Xalign = 0F;
            this.searchLocationLabel.LabelProp = Mono.Unix.Catalog.GetString("Search in:");
            this.hbox17.Add(this.searchLocationLabel);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.hbox17[this.searchLocationLabel]));
            w20.Position = 0;
            w20.Expand = false;
            // Container child hbox17.Gtk.Box+BoxChild
            this.searchLocationComboBox = new Gtk.ComboBox();
            this.searchLocationComboBox.Name = "searchLocationComboBox";
            this.hbox17.Add(this.searchLocationComboBox);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.hbox17[this.searchLocationComboBox]));
            w21.Position = 1;
            this.vbox15.Add(this.hbox17);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.vbox15[this.hbox17]));
            w22.Position = 5;
            w22.Expand = false;
            w22.Fill = false;
            w1.Add(this.vbox15);
            Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(w1[this.vbox15]));
            w23.Position = 0;
            w23.Expand = false;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.ReplaceInFilesDialog.ActionArea
            Gtk.HButtonBox w24 = this.ActionArea;
            w24.Name = "dialog-action_area2";
            w24.Spacing = 6;
            w24.BorderWidth = ((uint)(5));
            w24.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog-action_area2.Gtk.ButtonBox+ButtonBoxChild
            this.stopButton = new Gtk.Button();
            this.stopButton.Name = "stopButton";
            this.stopButton.UseStock = true;
            this.stopButton.UseUnderline = true;
            this.stopButton.Label = "gtk-stop";
            this.AddActionWidget(this.stopButton, 0);
            // Container child dialog-action_area2.Gtk.ButtonBox+ButtonBoxChild
            this.closeButton = new Gtk.Button();
            this.closeButton.Name = "closeButton";
            this.closeButton.UseStock = true;
            this.closeButton.UseUnderline = true;
            this.closeButton.Label = "gtk-close";
            this.AddActionWidget(this.closeButton, -7);
            Gtk.ButtonBox.ButtonBoxChild w26 = ((Gtk.ButtonBox.ButtonBoxChild)(w24[this.closeButton]));
            w26.Position = 1;
            // Container child dialog-action_area2.Gtk.ButtonBox+ButtonBoxChild
            this.replaceAllButton = new Gtk.Button();
            this.replaceAllButton.Name = "replaceAllButton";
            this.replaceAllButton.UseUnderline = true;
            // Container child replaceAllButton.Gtk.Container+ContainerChild
            Gtk.Alignment w27 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment2.Gtk.Container+ContainerChild
            Gtk.HBox w28 = new Gtk.HBox();
            w28.Spacing = 2;
            // Container child GtkHBox6.Gtk.Container+ContainerChild
            Gtk.Image w29 = new Gtk.Image();
            w29.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-find-and-replace", Gtk.IconSize.Button, 20);
            w28.Add(w29);
            // Container child GtkHBox6.Gtk.Container+ContainerChild
            Gtk.Label w31 = new Gtk.Label();
            w31.LabelProp = Mono.Unix.Catalog.GetString("R_eplace All");
            w31.UseUnderline = true;
            w28.Add(w31);
            w27.Add(w28);
            this.replaceAllButton.Add(w27);
            this.AddActionWidget(this.replaceAllButton, 0);
            Gtk.ButtonBox.ButtonBoxChild w35 = ((Gtk.ButtonBox.ButtonBoxChild)(w24[this.replaceAllButton]));
            w35.Position = 2;
            // Container child dialog-action_area2.Gtk.ButtonBox+ButtonBoxChild
            this.findButton = new Gtk.Button();
            this.findButton.CanDefault = true;
            this.findButton.Name = "findButton";
            this.findButton.UseStock = true;
            this.findButton.UseUnderline = true;
            this.findButton.Label = "gtk-find";
            this.AddActionWidget(this.findButton, 0);
            Gtk.ButtonBox.ButtonBoxChild w36 = ((Gtk.ButtonBox.ButtonBoxChild)(w24[this.findButton]));
            w36.Position = 3;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 518;
            this.DefaultHeight = 411;
            this.findButton.HasDefault = true;
            this.Show();
        }
    }
}
