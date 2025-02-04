// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.BoundingRectWithAnotherRange;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.CellWithRowWithColumn;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Clear;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.ColumnWithColumn;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.ColumnsAfter;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.ColumnsAfterWithCount;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.ColumnsBefore;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.ColumnsBeforeWithCount;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Delete;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.EntireColumn;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.EntireRow;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Format;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Insert;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.IntersectionWithAnotherRange;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.LastCell;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.LastColumn;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.LastRow;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Merge;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.OffsetRangeWithRowOffsetWithColumnOffset;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.ResizedRangeWithDeltaRowsWithDeltaColumns;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.RowWithRow;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.RowsAbove;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.RowsAboveWithCount;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.RowsBelow;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.RowsBelowWithCount;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Sort;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Unmerge;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.UsedRange;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.UsedRangeWithValuesOnly;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.VisibleView;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Worksheet;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange
{
    /// <summary>
    /// Provides operations to call the headerRowRange method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class HeaderRowRangeRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to call the boundingRect method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildBoundingRectWithAnotherRangeRbCommand()
        {
            var command = new Command("bounding-rect-with-another-range");
            command.Description = "Provides operations to call the boundingRect method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the cell method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCellWithRowWithColumnRbCommand()
        {
            var command = new Command("cell-with-row-with-column");
            command.Description = "Provides operations to call the cell method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the clear method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildClearNavCommand()
        {
            var command = new Command("clear");
            command.Description = "Provides operations to call the clear method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Clear.ClearRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the columnsAfter method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildColumnsAfterNavCommand()
        {
            var command = new Command("columns-after");
            command.Description = "Provides operations to call the columnsAfter method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.ColumnsAfter.ColumnsAfterRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the columnsAfter method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildColumnsAfterWithCountRbCommand()
        {
            var command = new Command("columns-after-with-count");
            command.Description = "Provides operations to call the columnsAfter method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the columnsBefore method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildColumnsBeforeNavCommand()
        {
            var command = new Command("columns-before");
            command.Description = "Provides operations to call the columnsBefore method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.ColumnsBefore.ColumnsBeforeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the columnsBefore method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildColumnsBeforeWithCountRbCommand()
        {
            var command = new Command("columns-before-with-count");
            command.Description = "Provides operations to call the columnsBefore method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the column method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildColumnWithColumnRbCommand()
        {
            var command = new Command("column-with-column");
            command.Description = "Provides operations to call the column method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.ColumnWithColumn.ColumnWithColumnRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the delete method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeletePathNavCommand()
        {
            var command = new Command("delete-path");
            command.Description = "Provides operations to call the delete method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Delete.DeleteRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the entireColumn method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildEntireColumnNavCommand()
        {
            var command = new Command("entire-column");
            command.Description = "Provides operations to call the entireColumn method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.EntireColumn.EntireColumnRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the entireRow method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildEntireRowNavCommand()
        {
            var command = new Command("entire-row");
            command.Description = "Provides operations to call the entireRow method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.EntireRow.EntireRowRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the format property of the microsoft.graph.workbookRange entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildFormatNavCommand()
        {
            var command = new Command("format");
            command.Description = "Provides operations to manage the format property of the microsoft.graph.workbookRange entity.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Format.FormatRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Gets the range object associated with the header row of the column.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/tablecolumn-headerrowrange?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Gets the range object associated with the header row of the column.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/tablecolumn-headerrowrange?view=graph-rest-1.0";
            var driveIdOption = new Option<string>("--drive-id", description: "The unique identifier of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "The unique identifier of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookWorksheetIdOption = new Option<string>("--workbook-worksheet-id", description: "The unique identifier of workbookWorksheet") {
            };
            workbookWorksheetIdOption.IsRequired = true;
            command.AddOption(workbookWorksheetIdOption);
            var workbookTableIdOption = new Option<string>("--workbook-table-id", description: "The unique identifier of workbookTable") {
            };
            workbookTableIdOption.IsRequired = true;
            command.AddOption(workbookTableIdOption);
            var workbookTableColumnIdOption = new Option<string>("--workbook-table-column-id", description: "The unique identifier of workbookTableColumn") {
            };
            workbookTableColumnIdOption.IsRequired = true;
            command.AddOption(workbookTableColumnIdOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var driveId = invocationContext.ParseResult.GetValueForOption(driveIdOption);
                var driveItemId = invocationContext.ParseResult.GetValueForOption(driveItemIdOption);
                var workbookWorksheetId = invocationContext.ParseResult.GetValueForOption(workbookWorksheetIdOption);
                var workbookTableId = invocationContext.ParseResult.GetValueForOption(workbookTableIdOption);
                var workbookTableColumnId = invocationContext.ParseResult.GetValueForOption(workbookTableColumnIdOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (driveId is not null) requestInfo.PathParameters.Add("drive%2Did", driveId);
                if (driveItemId is not null) requestInfo.PathParameters.Add("driveItem%2Did", driveItemId);
                if (workbookWorksheetId is not null) requestInfo.PathParameters.Add("workbookWorksheet%2Did", workbookWorksheetId);
                if (workbookTableId is not null) requestInfo.PathParameters.Add("workbookTable%2Did", workbookTableId);
                if (workbookTableColumnId is not null) requestInfo.PathParameters.Add("workbookTableColumn%2Did", workbookTableColumnId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the insert method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildInsertNavCommand()
        {
            var command = new Command("insert");
            command.Description = "Provides operations to call the insert method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Insert.InsertRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the intersection method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildIntersectionWithAnotherRangeRbCommand()
        {
            var command = new Command("intersection-with-another-range");
            command.Description = "Provides operations to call the intersection method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the lastCell method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildLastCellNavCommand()
        {
            var command = new Command("last-cell");
            command.Description = "Provides operations to call the lastCell method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.LastCell.LastCellRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the lastColumn method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildLastColumnNavCommand()
        {
            var command = new Command("last-column");
            command.Description = "Provides operations to call the lastColumn method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.LastColumn.LastColumnRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the lastRow method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildLastRowNavCommand()
        {
            var command = new Command("last-row");
            command.Description = "Provides operations to call the lastRow method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.LastRow.LastRowRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the merge method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMergeNavCommand()
        {
            var command = new Command("merge");
            command.Description = "Provides operations to call the merge method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Merge.MergeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the offsetRange method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildOffsetRangeWithRowOffsetWithColumnOffsetRbCommand()
        {
            var command = new Command("offset-range-with-row-offset-with-column-offset");
            command.Description = "Provides operations to call the offsetRange method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the resizedRange method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildResizedRangeWithDeltaRowsWithDeltaColumnsRbCommand()
        {
            var command = new Command("resized-range-with-delta-rows-with-delta-columns");
            command.Description = "Provides operations to call the resizedRange method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the rowsAbove method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRowsAboveNavCommand()
        {
            var command = new Command("rows-above");
            command.Description = "Provides operations to call the rowsAbove method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.RowsAbove.RowsAboveRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the rowsAbove method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRowsAboveWithCountRbCommand()
        {
            var command = new Command("rows-above-with-count");
            command.Description = "Provides operations to call the rowsAbove method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.RowsAboveWithCount.RowsAboveWithCountRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the rowsBelow method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRowsBelowNavCommand()
        {
            var command = new Command("rows-below");
            command.Description = "Provides operations to call the rowsBelow method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.RowsBelow.RowsBelowRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the rowsBelow method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRowsBelowWithCountRbCommand()
        {
            var command = new Command("rows-below-with-count");
            command.Description = "Provides operations to call the rowsBelow method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.RowsBelowWithCount.RowsBelowWithCountRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the row method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRowWithRowRbCommand()
        {
            var command = new Command("row-with-row");
            command.Description = "Provides operations to call the row method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.RowWithRow.RowWithRowRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the sort property of the microsoft.graph.workbookRange entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSortNavCommand()
        {
            var command = new Command("sort");
            command.Description = "Provides operations to manage the sort property of the microsoft.graph.workbookRange entity.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Sort.SortRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the unmerge method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildUnmergeNavCommand()
        {
            var command = new Command("unmerge");
            command.Description = "Provides operations to call the unmerge method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Unmerge.UnmergeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the usedRange method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildUsedRangeNavCommand()
        {
            var command = new Command("used-range");
            command.Description = "Provides operations to call the usedRange method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.UsedRange.UsedRangeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the usedRange method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildUsedRangeWithValuesOnlyRbCommand()
        {
            var command = new Command("used-range-with-values-only");
            command.Description = "Provides operations to call the usedRange method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the visibleView method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildVisibleViewNavCommand()
        {
            var command = new Command("visible-view");
            command.Description = "Provides operations to call the visibleView method.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.VisibleView.VisibleViewRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the worksheet property of the microsoft.graph.workbookRange entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildWorksheetNavCommand()
        {
            var command = new Command("worksheet");
            command.Description = "Provides operations to manage the worksheet property of the microsoft.graph.workbookRange entity.";
            var builder = new global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.Worksheet.WorksheetRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.HeaderRowRangeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public HeaderRowRangeRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/tables/{workbookTable%2Did}/columns/{workbookTableColumn%2Did}/headerRowRange()", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.HeaderRowRange.HeaderRowRangeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public HeaderRowRangeRequestBuilder(string rawUrl) : base("{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/tables/{workbookTable%2Did}/columns/{workbookTableColumn%2Did}/headerRowRange()", rawUrl)
        {
        }
        /// <summary>
        /// Gets the range object associated with the header row of the column.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
#pragma warning restore CS0618
