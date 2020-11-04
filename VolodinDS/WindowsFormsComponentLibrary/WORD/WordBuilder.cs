using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Office2013.Word;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using WindowsFormsComponentLibrary.WORD;
using A = DocumentFormat.OpenXml.Drawing;
using C = DocumentFormat.OpenXml.Drawing.Charts;

namespace WindowsFormsComponentLibrary
{
    public class WordBuilder
    {
        public void CreatePackage(WordDocData docData)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Create(docData.Path, WordprocessingDocumentType.Document))
            {
                CreateParts(package, docData);
            }
        }

        private void CreateParts(WordprocessingDocument document, WordDocData docData)
        {

            MainDocumentPart mainDocumentPart = document.AddMainDocumentPart();
            GenerateMainDocumentPartContent(mainDocumentPart);

            WebSettingsPart webSettingsPart = mainDocumentPart.AddNewPart<WebSettingsPart>("rId3");
            GenerateWebSettingsPartContent(webSettingsPart);

            DocumentSettingsPart documentSettingsPart = mainDocumentPart.AddNewPart<DocumentSettingsPart>("rId2");
            GenerateDocumentSettingsPartContent(documentSettingsPart);

            ChartPart chartPart = mainDocumentPart.AddNewPart<ChartPart>("rId4");
            GenerateChartPartContent(chartPart, docData);

            EmbeddedPackagePart embeddedPackagePart1 = 
                chartPart.AddNewPart<EmbeddedPackagePart>("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "rId3");
            GenerateEmbeddedPackagePartContent(embeddedPackagePart1);
        }

        private void GenerateMainDocumentPartContent(MainDocumentPart mainDocumentPart)
        {
            Document document = new Document();
            document.AddNamespaceDeclaration("cx", "http://schemas.microsoft.com/office/drawing/2014/chartex");
            document.AddNamespaceDeclaration("cx1", "http://schemas.microsoft.com/office/drawing/2015/9/8/chartex");
            document.AddNamespaceDeclaration("cx2", "http://schemas.microsoft.com/office/drawing/2015/10/21/chartex");
            document.AddNamespaceDeclaration("cx3", "http://schemas.microsoft.com/office/drawing/2016/5/9/chartex");
            document.AddNamespaceDeclaration("cx4", "http://schemas.microsoft.com/office/drawing/2016/5/10/chartex");
            document.AddNamespaceDeclaration("cx5", "http://schemas.microsoft.com/office/drawing/2016/5/11/chartex");
            document.AddNamespaceDeclaration("cx6", "http://schemas.microsoft.com/office/drawing/2016/5/12/chartex");
            document.AddNamespaceDeclaration("cx7", "http://schemas.microsoft.com/office/drawing/2016/5/13/chartex");
            document.AddNamespaceDeclaration("cx8", "http://schemas.microsoft.com/office/drawing/2016/5/14/chartex");
            document.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            document.AddNamespaceDeclaration("aink", "http://schemas.microsoft.com/office/drawing/2016/ink");
            document.AddNamespaceDeclaration("am3d", "http://schemas.microsoft.com/office/drawing/2017/model3d");
            document.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            document.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            document.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            document.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            document.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            document.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            document.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            document.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            document.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            document.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            document.AddNamespaceDeclaration("w16cex", "http://schemas.microsoft.com/office/word/2018/wordml/cex");
            document.AddNamespaceDeclaration("w16cid", "http://schemas.microsoft.com/office/word/2016/wordml/cid");
            document.AddNamespaceDeclaration("w16", "http://schemas.microsoft.com/office/word/2018/wordml");
            document.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");
            document.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            document.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            document.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            document.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Body body = new Body();

            Paragraph paragraph = new Paragraph();
            ParagraphProperties paragraphProperties = new ParagraphProperties();
            Justification justification = new Justification() { Val = JustificationValues.Center };

            paragraphProperties.Append(justification);

            Run run = new Run();

            RunProperties runProperties = new RunProperties();
            NoProof noProof = new NoProof();

            runProperties.Append(noProof);

            Drawing drawing = new Drawing();

            Inline inline = new Inline() 
            { 
                DistanceFromTop = 0U, 
                DistanceFromBottom = 0U, 
                DistanceFromLeft = 0U, 
                DistanceFromRight = 0U, 
                AnchorId = "6CBDE46E", 
                EditId = "48DA1236" 
            };
            Extent extent = new Extent() { Cx = 5486400L, Cy = 3200400L };
            EffectExtent effectExtent = new EffectExtent() 
            { 
                LeftEdge = 0L, 
                TopEdge = 0L, 
                RightEdge = 0L, 
                BottomEdge = 0L 
            };
            DocProperties docProperties = new DocProperties() { Id = 1U, Name = "Диаграмма" };
            NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties = new NonVisualGraphicFrameDrawingProperties();

            A.Graphic graphic = new A.Graphic();
            graphic.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.GraphicData graphicData = new A.GraphicData() { Uri = "http://schemas.openxmlformats.org/drawingml/2006/chart" };

            C.ChartReference chartReference = new C.ChartReference() { Id = "rId4" };
            chartReference.AddNamespaceDeclaration("c", "http://schemas.openxmlformats.org/drawingml/2006/chart");
            chartReference.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            graphicData.Append(chartReference);

            graphic.Append(graphicData);

            inline.Append(extent);
            inline.Append(effectExtent);
            inline.Append(docProperties);
            inline.Append(nonVisualGraphicFrameDrawingProperties);
            inline.Append(graphic);

            drawing.Append(inline);

            run.Append(runProperties);
            run.Append(drawing);

            paragraph.Append(paragraphProperties);
            paragraph.Append(run);

            SectionProperties sectionProperties = new SectionProperties() { RsidR = "00015474" };
            PageSize pageSize = new PageSize() { Width = 11906U, Height = 16838U };
            PageMargin pageMargin = new PageMargin() 
            { 
                Top = 1134, 
                Right = 850U, 
                Bottom = 1134, Left = 1701U, 
                Header = 708U, 
                Footer = 708U, 
                Gutter = 0U 
            };
            Columns columns = new Columns() { Space = "708" };
            DocGrid docGrid = new DocGrid() { LinePitch = 360 };

            sectionProperties.Append(pageSize);
            sectionProperties.Append(pageMargin);
            sectionProperties.Append(columns);
            sectionProperties.Append(docGrid);

            body.Append(paragraph);
            body.Append(sectionProperties);

            document.Append(body);

            mainDocumentPart.Document = document;
        }

        private void GenerateWebSettingsPartContent(WebSettingsPart webSettingsPart)
        {
            WebSettings webSettings = new WebSettings();
            webSettings.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            webSettings.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            webSettings.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            webSettings.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            webSettings.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            webSettings.AddNamespaceDeclaration("w16cex", "http://schemas.microsoft.com/office/word/2018/wordml/cex");
            webSettings.AddNamespaceDeclaration("w16cid", "http://schemas.microsoft.com/office/word/2016/wordml/cid");
            webSettings.AddNamespaceDeclaration("w16", "http://schemas.microsoft.com/office/word/2018/wordml");
            webSettings.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");
            OptimizeForBrowser optimizeForBrowser = new OptimizeForBrowser();
            AllowPNG allowPNG = new AllowPNG();

            webSettings.Append(optimizeForBrowser);
            webSettings.Append(allowPNG);

            webSettingsPart.WebSettings = webSettings;
        }

        private void GenerateDocumentSettingsPartContent(DocumentSettingsPart documentSettingsPart)
        {
            Settings settings = new Settings();
            settings.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            settings.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            settings.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            settings.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            settings.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            settings.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            settings.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            settings.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            settings.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            settings.AddNamespaceDeclaration("w16cex", "http://schemas.microsoft.com/office/word/2018/wordml/cex");
            settings.AddNamespaceDeclaration("w16cid", "http://schemas.microsoft.com/office/word/2016/wordml/cid");
            settings.AddNamespaceDeclaration("w16", "http://schemas.microsoft.com/office/word/2018/wordml");
            settings.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");
            settings.AddNamespaceDeclaration("sl", "http://schemas.openxmlformats.org/schemaLibrary/2006/main");
            Zoom zoom = new Zoom() { Percent = "100" };
            ProofState proofState = new ProofState() { Grammar = ProofingStateValues.Clean };
            DefaultTabStop defaultTabStop = new DefaultTabStop() { Val = 708 };
            CharacterSpacingControl characterSpacingControl = new CharacterSpacingControl() 
            { 
                Val = CharacterSpacingValues.DoNotCompress 
            };

            Compatibility compatibility = new Compatibility();
            CompatibilitySetting compatibilityMode = new CompatibilitySetting() 
            { 
                Name = CompatSettingNameValues.CompatibilityMode, 
                Uri = "http://schemas.microsoft.com/office/word", 
                Val = "15" 
            };
            CompatibilitySetting overrideStyles = new CompatibilitySetting() 
            { 
                Name = CompatSettingNameValues.OverrideTableStyleFontSizeAndJustification, 
                Uri = "http://schemas.microsoft.com/office/word", 
                Val = "1" };
            CompatibilitySetting openType = new CompatibilitySetting() 
            { 
                Name = CompatSettingNameValues.EnableOpenTypeFeatures, 
                Uri = "http://schemas.microsoft.com/office/word", 
                Val = "1" 
            };
            CompatibilitySetting dontFlip = new CompatibilitySetting() 
            { 
                Name = CompatSettingNameValues.DoNotFlipMirrorIndents, 
                Uri = "http://schemas.microsoft.com/office/word", 
                Val = "1" 
            };
            CompatibilitySetting multirowHeaders = new CompatibilitySetting() 
            { 
                Name = CompatSettingNameValues.DifferentiateMultirowTableHeaders,
                Uri = "http://schemas.microsoft.com/office/word", 
                Val = "1" 
            };
            CompatibilitySetting hyphenation = new CompatibilitySetting() 
            { 
                Name = new EnumValue<CompatSettingNameValues>() { InnerText = "useWord2013TrackBottomHyphenation" }, 
                Uri = "http://schemas.microsoft.com/office/word", 
                Val = "0" 
            };

            compatibility.Append(compatibilityMode);
            compatibility.Append(overrideStyles);
            compatibility.Append(openType);
            compatibility.Append(dontFlip);
            compatibility.Append(multirowHeaders);
            compatibility.Append(hyphenation);

            ThemeFontLanguages themeFontLanguages = new ThemeFontLanguages() { Val = "ru-RU" };

            DocumentId documentId = new DocumentId() { Val = "0F94B6D9" };
            ChartTrackingRefBased chartTrackingRefBased = new ChartTrackingRefBased();
            PersistentDocumentId persistentDocumentId1 = new PersistentDocumentId() 
            { 
                Val = "{CB3386B8-2A2C-4C16-9276-1BD1690AFE31}" 
            };

            settings.Append(zoom);
            settings.Append(proofState);
            settings.Append(defaultTabStop);
            settings.Append(characterSpacingControl);
            settings.Append(compatibility);
            settings.Append(themeFontLanguages);
            settings.Append(documentId);
            settings.Append(chartTrackingRefBased);
            settings.Append(persistentDocumentId1);

            documentSettingsPart.Settings = settings;
        }


        private void GenerateChartPartContent(ChartPart chartPart, WordDocData docData)
        {
            C.ChartSpace chartSpace = new C.ChartSpace();

            chartSpace.AddNamespaceDeclaration("c", "http://schemas.openxmlformats.org/drawingml/2006/chart");
            chartSpace.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            chartSpace.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            chartSpace.AddNamespaceDeclaration("c16r2", "http://schemas.microsoft.com/office/drawing/2015/06/chart");

            C.Date1904 date1904 = new C.Date1904() { Val = false };
            C.EditingLanguage editingLanguage = new C.EditingLanguage() { Val = "ru-RU" };
            C.RoundedCorners roundedCorners = new C.RoundedCorners() { Val = false };

            C.Chart chart = new C.Chart();

            #region Title

            C.Title title = new C.Title();

            C.ChartText chartText = new C.ChartText();

            C.RichText richText = new C.RichText();
            A.BodyProperties bodyProperties = new A.BodyProperties() 
            { 
                Rotation = 0, 
                UseParagraphSpacing = true, 
                VerticalOverflow = A.TextVerticalOverflowValues.Ellipsis, 
                Vertical = A.TextVerticalValues.Horizontal, 
                Wrap = A.TextWrappingValues.Square, 
                Anchor = A.TextAnchoringTypeValues.Center, 
                AnchorCenter = true 
            };
            A.ListStyle listStyle = new A.ListStyle();

            A.Paragraph titleParagraph = new A.Paragraph();

            A.ParagraphProperties paragraphProperties = new A.ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties = new A.DefaultRunProperties() 
            { 
                FontSize = 1400, 
                Bold = false, 
                Italic = false, 
                Underline = A.TextUnderlineValues.None, 
                Strike = A.TextStrikeValues.NoStrike, 
                Kerning = 1200, 
                Spacing = 0, 
                Baseline = 0 
            };

            paragraphProperties.Append(defaultRunProperties);

            A.Run run = new A.Run();
            A.RunProperties runProperties = new A.RunProperties() { Language = "ru-RU" };
            A.Text text = new A.Text
            {
                Text = !string.IsNullOrEmpty(docData.DiagramName) ? docData.DiagramName : "Без названия"
            };

            run.Append(runProperties);
            run.Append(text);

            A.EndParagraphRunProperties endParagraphRunProperties = new A.EndParagraphRunProperties() { Language = "ru-RU" };

            titleParagraph.Append(paragraphProperties);
            titleParagraph.Append(run);
            titleParagraph.Append(endParagraphRunProperties);

            richText.Append(bodyProperties);
            richText.Append(listStyle);
            richText.Append(titleParagraph);

            chartText.Append(richText);

            C.Overlay overlay = new C.Overlay() { Val = false };

            title.Append(chartText);
            title.Append(overlay);

            #endregion

            C.AutoTitleDeleted autoTitleDeleted = new C.AutoTitleDeleted() { Val = false };

            C.PlotArea plotArea = new C.PlotArea();
            C.Layout layout = new C.Layout();

            C.BarChart barChart = new C.BarChart();
            C.BarDirection barDirection = new C.BarDirection() { Val = C.BarDirectionValues.Column };
            C.BarGrouping barGrouping = new C.BarGrouping() { Val = C.BarGroupingValues.Clustered };
            C.VaryColors varyColors = new C.VaryColors() { Val = false };

            #region Bar Chart Series

            List<BarChartSeries> barCharts = new List<BarChartSeries>();

            for (int i = 0; i < docData.Data.Columns.Count; i++)
            {
                C.BarChartSeries barChartSeries = new C.BarChartSeries();
                C.Index index = new C.Index() { Val = Convert.ToUInt32(i) };
                C.Order order = new C.Order() { Val = Convert.ToUInt32(i) };
                C.SeriesText seriesText = new C.SeriesText();   

                C.StringReference columnStringReference = new C.StringReference();

                C.StringCache columnStringCache = new C.StringCache();
                C.PointCount columnPointCount = new C.PointCount() { Val = (UInt32Value)1U };

                C.StringPoint columnStringPoint = new C.StringPoint() { Index = (UInt32Value)0U };
                C.NumericValue columnName = new C.NumericValue();
                if (!string.IsNullOrEmpty(docData.Data.Columns[i].ColumnName))
                {
                    columnName.Text = docData.Data.Columns[i].ColumnName;
                }
                else
                {
                    columnName.Text = $"Параметр #{i}";
                }

                columnStringPoint.Append(columnName);

                columnStringCache.Append(columnPointCount);
                columnStringCache.Append(columnStringPoint);

                columnStringReference.Append(columnStringCache);

                seriesText.Append(columnStringReference);

                C.InvertIfNegative invertIfNegative = new C.InvertIfNegative() { Val = false };
                C.CategoryAxisData categoryAxisData = new C.CategoryAxisData();

                C.StringReference categoryStringReference = new C.StringReference();

                C.StringCache categoryStringCache = new C.StringCache();
                C.PointCount categoryPointCount = new C.PointCount() 
                { 
                    Val = Convert.ToUInt32(docData.Data.Rows.Count) 
                };

                List<C.StringPoint> stringPoints = new List<StringPoint>();

                for (int j = 0; j < docData.Data.Rows.Count; j++)
                {
                    C.StringPoint stringPoint = new C.StringPoint() { Index = Convert.ToUInt32(j) };
                    C.NumericValue numericValue = new C.NumericValue();
                    if (!string.IsNullOrEmpty(docData.CategoryNames[j]))
                    {
                        numericValue.Text = docData.CategoryNames[j];
                    }
                    else
                    {
                        numericValue.Text = $"Измерение #{j}";

                    }
                    stringPoint.Append(numericValue);
                    stringPoints.Add(stringPoint);
                }

                categoryStringCache.Append(categoryPointCount);
                foreach (var stringPointElem in stringPoints)
                {
                    categoryStringCache.Append(stringPointElem);
                }

                categoryStringReference.Append(categoryStringCache);

                categoryAxisData.Append(categoryStringReference);

                C.Values values = new C.Values();

                C.NumberReference numberReference = new C.NumberReference();

                C.NumberingCache numberingCache = new C.NumberingCache();
                C.FormatCode formatCode = new C.FormatCode
                {
                    Text = "General"
                };
                C.PointCount pointCount = new C.PointCount() { Val = Convert.ToUInt32(docData.Data.Rows.Count) };

                List<C.NumericPoint> numericPoints = new List<NumericPoint>();
                for (int j = 0; j < docData.Data.Rows.Count; j++)
                {
                    C.NumericPoint numericPoint = new C.NumericPoint() { Index = Convert.ToUInt32(j) };
                    C.NumericValue numericValue = new C.NumericValue();
                    numericValue.Text = docData.Data.Rows[j].ItemArray[i].ToString();
                    numericPoint.Append(numericValue);
                    numericPoints.Add(numericPoint);
                }

                numberingCache.Append(formatCode);
                numberingCache.Append(pointCount);
                foreach (var numericPointElem in numericPoints)
                {
                    numberingCache.Append(numericPointElem);
                }
                numberReference.Append(numberingCache);

                values.Append(numberReference);

                barChartSeries.Append(index);
                barChartSeries.Append(order);
                barChartSeries.Append(seriesText);
                barChartSeries.Append(invertIfNegative);
                barChartSeries.Append(categoryAxisData);
                barChartSeries.Append(values);

                barCharts.Add(barChartSeries);
            }

            #endregion

            #region Data Labels

            C.DataLabels dataLabels = new C.DataLabels();

            C.ShowLegendKey showLegendKey = new C.ShowLegendKey() { Val = false };
            C.ShowValue showValue = new C.ShowValue() { Val = false };
            C.ShowCategoryName showCategoryName = new C.ShowCategoryName() { Val = false };
            C.ShowSeriesName showSeriesName = new C.ShowSeriesName() { Val = false };
            C.ShowPercent showPercent = new C.ShowPercent() { Val = false };
            C.ShowBubbleSize showBubbleSize = new C.ShowBubbleSize() { Val = false };

            dataLabels.Append(showLegendKey);
            dataLabels.Append(showValue);
            dataLabels.Append(showCategoryName);
            dataLabels.Append(showSeriesName);
            dataLabels.Append(showPercent);
            dataLabels.Append(showBubbleSize);
            C.GapWidth gapWidth = new C.GapWidth() { Val = (UInt16Value)219U };
            C.Overlap overlap = new C.Overlap() { Val = -27 };
            C.AxisId firstAxisId = new C.AxisId() { Val = (UInt32Value)425627648U };
            C.AxisId secondAxisId = new C.AxisId() { Val = (UInt32Value)425626664U };

            barChart.Append(barDirection);
            barChart.Append(barGrouping);
            barChart.Append(varyColors);
            foreach (var barChartElem in barCharts)
            {
                barChart.Append(barChartElem);
            }
            barChart.Append(dataLabels);
            barChart.Append(gapWidth);
            barChart.Append(overlap);
            barChart.Append(firstAxisId);
            barChart.Append(secondAxisId);

            #endregion

            #region Category Axis

            C.CategoryAxis categoryAxis = new C.CategoryAxis();
            C.AxisId categoryAxisId = new C.AxisId() { Val = (UInt32Value)425627648U };

            C.Scaling scaling = new C.Scaling();
            C.Orientation orientation = new C.Orientation() { Val = C.OrientationValues.MinMax };
            scaling.Append(orientation);

            C.Delete delete = new C.Delete() { Val = false };
            C.AxisPosition axisPosition = new C.AxisPosition() { Val = C.AxisPositionValues.Bottom };
            C.NumberingFormat numberingFormat = new C.NumberingFormat() { FormatCode = "General", SourceLinked = false };
            C.MajorTickMark majorTickMark = new C.MajorTickMark() { Val = C.TickMarkValues.None };
            C.MinorTickMark minorTickMark = new C.MinorTickMark() { Val = C.TickMarkValues.None };
            C.TickLabelPosition tickLabelPosition = new C.TickLabelPosition() { Val = C.TickLabelPositionValues.NextTo };

            C.TextProperties axisTextProperties = new C.TextProperties();

            A.BodyProperties axisBodyProperties = new A.BodyProperties() 
            { 
                Rotation = -60000000, 
                UseParagraphSpacing = true, 
                VerticalOverflow = A.TextVerticalOverflowValues.Ellipsis,
                Vertical = A.TextVerticalValues.Horizontal, 
                Wrap = A.TextWrappingValues.Square, 
                Anchor = A.TextAnchoringTypeValues.Center, 
                AnchorCenter = true 
            };

            A.ListStyle categoryAxisListStyle = new A.ListStyle();

            A.Paragraph categoryAxisParagraph = new A.Paragraph();

            A.ParagraphProperties categoryAxisParagraphProperties = new A.ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties3 = new A.DefaultRunProperties() 
            { 
                FontSize = 900, 
                Bold = false, 
                Italic = false,
                Underline = A.TextUnderlineValues.None, 
                Strike = A.TextStrikeValues.NoStrike, 
                Kerning = 1200, 
                Baseline = 0 
            };

            categoryAxisParagraphProperties.Append(defaultRunProperties3);
            A.EndParagraphRunProperties categoryAxisEndParagraphRunProperties = 
                new A.EndParagraphRunProperties() { Language = "ru-RU" };

            categoryAxisParagraph.Append(categoryAxisParagraphProperties);
            categoryAxisParagraph.Append(categoryAxisEndParagraphRunProperties);

            axisTextProperties.Append(axisBodyProperties);
            axisTextProperties.Append(categoryAxisListStyle);
            axisTextProperties.Append(categoryAxisParagraph);

            C.CrossingAxis crossingAxis = new C.CrossingAxis() { Val = (UInt32Value)425626664U };
            C.Crosses crosses = new C.Crosses() { Val = C.CrossesValues.AutoZero };
            C.AutoLabeled autoLabeled = new C.AutoLabeled() { Val = true };
            C.LabelAlignment labelAlignment = new C.LabelAlignment() { Val = C.LabelAlignmentValues.Center };
            C.LabelOffset labelOffset = new C.LabelOffset() { Val = (UInt16Value)100U };
            C.NoMultiLevelLabels noMultiLevelLabels = new C.NoMultiLevelLabels() { Val = false };

            categoryAxis.Append(categoryAxisId);
            categoryAxis.Append(scaling);
            categoryAxis.Append(delete);
            categoryAxis.Append(axisPosition);
            categoryAxis.Append(numberingFormat);
            categoryAxis.Append(majorTickMark);
            categoryAxis.Append(minorTickMark);
            categoryAxis.Append(tickLabelPosition);
            categoryAxis.Append(axisTextProperties);
            categoryAxis.Append(crossingAxis);
            categoryAxis.Append(crosses);
            categoryAxis.Append(autoLabeled);
            categoryAxis.Append(labelAlignment);
            categoryAxis.Append(labelOffset);
            categoryAxis.Append(noMultiLevelLabels);

            #endregion

            #region Value Axis

            C.ValueAxis valueAxis = new C.ValueAxis();
            C.AxisId valueAxisId = new C.AxisId(){ Val = (UInt32Value)425626664U };

            C.Scaling valueAxisScaling = new C.Scaling();
            C.Orientation valueAxisOrientation = new C.Orientation(){ Val = C.OrientationValues.MinMax };

            valueAxisScaling.Append(valueAxisOrientation);
            C.Delete valueAxisDelete = new C.Delete(){ Val = false };
            C.AxisPosition valueAxisPosition = new C.AxisPosition(){ Val = C.AxisPositionValues.Left };
            C.NumberingFormat valueAxisNumberingFormat = new C.NumberingFormat(){ FormatCode = "General", SourceLinked = false };
            C.MajorTickMark valueAxisMajorTickMark = new C.MajorTickMark(){ Val = C.TickMarkValues.Outside };
            C.MinorTickMark valueAxisMinorTickMark = new C.MinorTickMark(){ Val = C.TickMarkValues.None };
            C.TickLabelPosition valueAxisTickLabelPosition = new C.TickLabelPosition(){ Val = C.TickLabelPositionValues.NextTo };

            C.TextProperties valueAxisTextProperties = new C.TextProperties();
            A.BodyProperties valueAxisBodyProperties = new A.BodyProperties()
            { 
                Rotation = -60000000, 
                UseParagraphSpacing = true, 
                VerticalOverflow = A.TextVerticalOverflowValues.Ellipsis, 
                Vertical = A.TextVerticalValues.Horizontal, 
                Wrap = A.TextWrappingValues.Square, 
                Anchor = A.TextAnchoringTypeValues.Center, 
                AnchorCenter = true 
            };
            A.ListStyle valueAxisListStyle = new A.ListStyle();
            A.Paragraph valueAxisParagraph = new A.Paragraph();
            A.ParagraphProperties valueAxisParagraphProperties = new A.ParagraphProperties();
            A.DefaultRunProperties valueAxisDefaultRunProperties = new A.DefaultRunProperties()
            { 
                FontSize = 900, 
                Bold = false, 
                Italic = false,
                Underline = A.TextUnderlineValues.None, 
                Strike = A.TextStrikeValues.NoStrike,
                Kerning = 1200, 
                Baseline = 0 
            };

            valueAxisParagraphProperties.Append(valueAxisDefaultRunProperties);
            A.EndParagraphRunProperties valueEndParagraphRunProperties = new A.EndParagraphRunProperties(){ Language = "ru-RU" };

            valueAxisParagraph.Append(valueAxisParagraphProperties);
            valueAxisParagraph.Append(valueEndParagraphRunProperties);

            valueAxisTextProperties.Append(valueAxisBodyProperties);
            valueAxisTextProperties.Append(valueAxisListStyle);
            valueAxisTextProperties.Append(valueAxisParagraph);
            C.CrossingAxis valueCrossingAxis = new C.CrossingAxis(){ Val = (UInt32Value)425627648U };
            C.Crosses valueCrosses = new C.Crosses(){ Val = C.CrossesValues.AutoZero };
            C.CrossBetween valueCrossBetween = new C.CrossBetween(){ Val = C.CrossBetweenValues.Between };

            valueAxis.Append(valueAxisId);
            valueAxis.Append(valueAxisScaling);
            valueAxis.Append(valueAxisDelete);
            valueAxis.Append(valueAxisPosition);
            valueAxis.Append(valueAxisNumberingFormat);
            valueAxis.Append(valueAxisMajorTickMark);
            valueAxis.Append(valueAxisMinorTickMark);
            valueAxis.Append(valueAxisTickLabelPosition);
            valueAxis.Append(valueAxisTextProperties);
            valueAxis.Append(valueCrossingAxis);
            valueAxis.Append(valueCrosses);
            valueAxis.Append(valueCrossBetween);

            #endregion

            plotArea.Append(layout);
            plotArea.Append(barChart);
            plotArea.Append(categoryAxis);
            plotArea.Append(valueAxis);

            #region Legend

            C.Legend legend = new C.Legend();
            C.LegendPosition legendPosition = new C.LegendPosition() { Val = C.LegendPositionValues.Top };
            C.Overlay legendOverlay = new C.Overlay() { Val = false };

            C.TextProperties legendTextProperties = new C.TextProperties();
            A.BodyProperties legendBodyProperties = new A.BodyProperties() 
            { 
                Rotation = 0, 
                UseParagraphSpacing = true, 
                VerticalOverflow = A.TextVerticalOverflowValues.Ellipsis, 
                Vertical = A.TextVerticalValues.Horizontal, 
                Wrap = A.TextWrappingValues.Square, 
                Anchor = A.TextAnchoringTypeValues.Center, 
                AnchorCenter = true 
            };

            A.ListStyle legendListStyle = new A.ListStyle();

            A.Paragraph legendParagraph = new A.Paragraph();

            A.ParagraphProperties legendParagraphProperties = new A.ParagraphProperties();

            A.DefaultRunProperties legendDefaultRunProperties = new A.DefaultRunProperties() 
            { 
                FontSize = 900, 
                Bold = false, 
                Italic = false, 
                Underline = A.TextUnderlineValues.None, 
                Strike = A.TextStrikeValues.NoStrike, 
                Kerning = 1200, Baseline = 0 
            };

            legendParagraphProperties.Append(legendDefaultRunProperties);
            A.EndParagraphRunProperties endParagraphRunProperties4 = new A.EndParagraphRunProperties() { Language = "ru-RU" };

            legendParagraph.Append(legendParagraphProperties);
            legendParagraph.Append(endParagraphRunProperties4);

            legendTextProperties.Append(legendBodyProperties);
            legendTextProperties.Append(legendListStyle);
            legendTextProperties.Append(legendParagraph);

            legend.Append(legendPosition);
            legend.Append(legendOverlay);
            legend.Append(legendTextProperties);

            #endregion

            C.PlotVisibleOnly plotVisibleOnly = new C.PlotVisibleOnly() { Val = true };
            C.DisplayBlanksAs displayBlanksAs = new C.DisplayBlanksAs() { Val = C.DisplayBlanksAsValues.Gap };

            C.ShowDataLabelsOverMaximum showDataLabelsOverMaximum = new C.ShowDataLabelsOverMaximum() { Val = false };

            chart.Append(title);
            chart.Append(autoTitleDeleted);
            chart.Append(plotArea);
            chart.Append(legend);
            chart.Append(plotVisibleOnly);
            chart.Append(displayBlanksAs);
            chart.Append(showDataLabelsOverMaximum);

            C.ExternalData externalData = new C.ExternalData() { Id = "rId3" };
            C.AutoUpdate autoUpdate = new C.AutoUpdate() { Val = false };

            externalData.Append(autoUpdate);

            chartSpace.Append(date1904);
            chartSpace.Append(editingLanguage);
            chartSpace.Append(roundedCorners);
            chartSpace.Append(chart);
            chartSpace.Append(externalData);

            chartPart.ChartSpace = chartSpace;
        }

        private void GenerateEmbeddedPackagePartContent(EmbeddedPackagePart embeddedPackagePart)
        {
            System.IO.Stream data = GetBinaryDataStream(embeddedPackagePartData);
            embeddedPackagePart.FeedData(data);
            data.Close();
        }

        #region Binary Data
        private string embeddedPackagePartData = "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";

        private System.IO.Stream GetBinaryDataStream(string base64String)
        {
            return new System.IO.MemoryStream(System.Convert.FromBase64String(base64String));
        }

        #endregion
    }
}