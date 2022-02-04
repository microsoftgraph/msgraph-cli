using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Workbook.Application;
using ApiSdk.Workbooks.Item.Workbook.CloseSession;
using ApiSdk.Workbooks.Item.Workbook.Comments;
using ApiSdk.Workbooks.Item.Workbook.CreateSession;
using ApiSdk.Workbooks.Item.Workbook.Functions;
using ApiSdk.Workbooks.Item.Workbook.Names;
using ApiSdk.Workbooks.Item.Workbook.Operations;
using ApiSdk.Workbooks.Item.Workbook.RefreshSession;
using ApiSdk.Workbooks.Item.Workbook.SessionInfoResourceWithKey;
using ApiSdk.Workbooks.Item.Workbook.TableRowOperationResultWithKey;
using ApiSdk.Workbooks.Item.Workbook.Tables;
using ApiSdk.Workbooks.Item.Workbook.Worksheets;
using Microsoft.Graph.Cli.Core.IO;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Workbooks.Item.Workbook {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook</summary>
    public class WorkbookRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildApplicationCommand() {
            var command = new Command("application");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Application.ApplicationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCalculateCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        public Command BuildCloseSessionCommand() {
            var command = new Command("close-session");
            var builder = new ApiSdk.Workbooks.Item.Workbook.CloseSession.CloseSessionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCommentsCommand() {
            var command = new Command("comments");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Comments.CommentsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildCreateSessionCommand() {
            var command = new Command("create-session");
            var builder = new ApiSdk.Workbooks.Item.Workbook.CreateSession.CreateSessionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--driveitem-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            command.SetHandler(async (string driveItemId, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                console.WriteLine("Success");
            }, driveItemIdOption);
            return command;
        }
        public Command BuildFunctionsCommand() {
            var command = new Command("functions");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.FunctionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAbsCommand());
            command.AddCommand(builder.BuildAccrIntCommand());
            command.AddCommand(builder.BuildAccrIntMCommand());
            command.AddCommand(builder.BuildAcosCommand());
            command.AddCommand(builder.BuildAcoshCommand());
            command.AddCommand(builder.BuildAcotCommand());
            command.AddCommand(builder.BuildAcothCommand());
            command.AddCommand(builder.BuildAmorDegrcCommand());
            command.AddCommand(builder.BuildAmorLincCommand());
            command.AddCommand(builder.BuildAndCommand());
            command.AddCommand(builder.BuildArabicCommand());
            command.AddCommand(builder.BuildAreasCommand());
            command.AddCommand(builder.BuildAscCommand());
            command.AddCommand(builder.BuildAsinCommand());
            command.AddCommand(builder.BuildAsinhCommand());
            command.AddCommand(builder.BuildAtan2Command());
            command.AddCommand(builder.BuildAtanCommand());
            command.AddCommand(builder.BuildAtanhCommand());
            command.AddCommand(builder.BuildAveDevCommand());
            command.AddCommand(builder.BuildAverageACommand());
            command.AddCommand(builder.BuildAverageCommand());
            command.AddCommand(builder.BuildAverageIfCommand());
            command.AddCommand(builder.BuildAverageIfsCommand());
            command.AddCommand(builder.BuildBahtTextCommand());
            command.AddCommand(builder.BuildBaseCommand());
            command.AddCommand(builder.BuildBesselICommand());
            command.AddCommand(builder.BuildBesselJCommand());
            command.AddCommand(builder.BuildBesselKCommand());
            command.AddCommand(builder.BuildBesselYCommand());
            command.AddCommand(builder.BuildBeta_DistCommand());
            command.AddCommand(builder.BuildBeta_InvCommand());
            command.AddCommand(builder.BuildBin2DecCommand());
            command.AddCommand(builder.BuildBin2HexCommand());
            command.AddCommand(builder.BuildBin2OctCommand());
            command.AddCommand(builder.BuildBinom_Dist_RangeCommand());
            command.AddCommand(builder.BuildBinom_DistCommand());
            command.AddCommand(builder.BuildBinom_InvCommand());
            command.AddCommand(builder.BuildBitandCommand());
            command.AddCommand(builder.BuildBitlshiftCommand());
            command.AddCommand(builder.BuildBitorCommand());
            command.AddCommand(builder.BuildBitrshiftCommand());
            command.AddCommand(builder.BuildBitxorCommand());
            command.AddCommand(builder.BuildCeiling_MathCommand());
            command.AddCommand(builder.BuildCeiling_PreciseCommand());
            command.AddCommand(builder.BuildCharCommand());
            command.AddCommand(builder.BuildChiSq_Dist_RTCommand());
            command.AddCommand(builder.BuildChiSq_DistCommand());
            command.AddCommand(builder.BuildChiSq_Inv_RTCommand());
            command.AddCommand(builder.BuildChiSq_InvCommand());
            command.AddCommand(builder.BuildChooseCommand());
            command.AddCommand(builder.BuildCleanCommand());
            command.AddCommand(builder.BuildCodeCommand());
            command.AddCommand(builder.BuildColumnsCommand());
            command.AddCommand(builder.BuildCombinaCommand());
            command.AddCommand(builder.BuildCombinCommand());
            command.AddCommand(builder.BuildComplexCommand());
            command.AddCommand(builder.BuildConcatenateCommand());
            command.AddCommand(builder.BuildConfidence_NormCommand());
            command.AddCommand(builder.BuildConfidence_TCommand());
            command.AddCommand(builder.BuildConvertCommand());
            command.AddCommand(builder.BuildCosCommand());
            command.AddCommand(builder.BuildCoshCommand());
            command.AddCommand(builder.BuildCotCommand());
            command.AddCommand(builder.BuildCothCommand());
            command.AddCommand(builder.BuildCountACommand());
            command.AddCommand(builder.BuildCountBlankCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCountIfCommand());
            command.AddCommand(builder.BuildCountIfsCommand());
            command.AddCommand(builder.BuildCoupDayBsCommand());
            command.AddCommand(builder.BuildCoupDaysCommand());
            command.AddCommand(builder.BuildCoupDaysNcCommand());
            command.AddCommand(builder.BuildCoupNcdCommand());
            command.AddCommand(builder.BuildCoupNumCommand());
            command.AddCommand(builder.BuildCoupPcdCommand());
            command.AddCommand(builder.BuildCscCommand());
            command.AddCommand(builder.BuildCschCommand());
            command.AddCommand(builder.BuildCumIPmtCommand());
            command.AddCommand(builder.BuildCumPrincCommand());
            command.AddCommand(builder.BuildDateCommand());
            command.AddCommand(builder.BuildDatevalueCommand());
            command.AddCommand(builder.BuildDaverageCommand());
            command.AddCommand(builder.BuildDayCommand());
            command.AddCommand(builder.BuildDays360Command());
            command.AddCommand(builder.BuildDaysCommand());
            command.AddCommand(builder.BuildDbCommand());
            command.AddCommand(builder.BuildDbcsCommand());
            command.AddCommand(builder.BuildDcountACommand());
            command.AddCommand(builder.BuildDcountCommand());
            command.AddCommand(builder.BuildDdbCommand());
            command.AddCommand(builder.BuildDec2BinCommand());
            command.AddCommand(builder.BuildDec2HexCommand());
            command.AddCommand(builder.BuildDec2OctCommand());
            command.AddCommand(builder.BuildDecimalCommand());
            command.AddCommand(builder.BuildDegreesCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildDeltaCommand());
            command.AddCommand(builder.BuildDevSqCommand());
            command.AddCommand(builder.BuildDgetCommand());
            command.AddCommand(builder.BuildDiscCommand());
            command.AddCommand(builder.BuildDmaxCommand());
            command.AddCommand(builder.BuildDminCommand());
            command.AddCommand(builder.BuildDollarCommand());
            command.AddCommand(builder.BuildDollarDeCommand());
            command.AddCommand(builder.BuildDollarFrCommand());
            command.AddCommand(builder.BuildDproductCommand());
            command.AddCommand(builder.BuildDstDevCommand());
            command.AddCommand(builder.BuildDstDevPCommand());
            command.AddCommand(builder.BuildDsumCommand());
            command.AddCommand(builder.BuildDurationCommand());
            command.AddCommand(builder.BuildDvarCommand());
            command.AddCommand(builder.BuildDvarPCommand());
            command.AddCommand(builder.BuildEcma_CeilingCommand());
            command.AddCommand(builder.BuildEdateCommand());
            command.AddCommand(builder.BuildEffectCommand());
            command.AddCommand(builder.BuildEoMonthCommand());
            command.AddCommand(builder.BuildErf_PreciseCommand());
            command.AddCommand(builder.BuildErfC_PreciseCommand());
            command.AddCommand(builder.BuildErfCCommand());
            command.AddCommand(builder.BuildErfCommand());
            command.AddCommand(builder.BuildError_TypeCommand());
            command.AddCommand(builder.BuildEvenCommand());
            command.AddCommand(builder.BuildExactCommand());
            command.AddCommand(builder.BuildExpCommand());
            command.AddCommand(builder.BuildExpon_DistCommand());
            command.AddCommand(builder.BuildF_Dist_RTCommand());
            command.AddCommand(builder.BuildF_DistCommand());
            command.AddCommand(builder.BuildF_Inv_RTCommand());
            command.AddCommand(builder.BuildF_InvCommand());
            command.AddCommand(builder.BuildFactCommand());
            command.AddCommand(builder.BuildFactDoubleCommand());
            command.AddCommand(builder.BuildFalseCommand());
            command.AddCommand(builder.BuildFindBCommand());
            command.AddCommand(builder.BuildFindCommand());
            command.AddCommand(builder.BuildFisherCommand());
            command.AddCommand(builder.BuildFisherInvCommand());
            command.AddCommand(builder.BuildFixedCommand());
            command.AddCommand(builder.BuildFloor_MathCommand());
            command.AddCommand(builder.BuildFloor_PreciseCommand());
            command.AddCommand(builder.BuildFvCommand());
            command.AddCommand(builder.BuildFvscheduleCommand());
            command.AddCommand(builder.BuildGamma_DistCommand());
            command.AddCommand(builder.BuildGamma_InvCommand());
            command.AddCommand(builder.BuildGammaCommand());
            command.AddCommand(builder.BuildGammaLn_PreciseCommand());
            command.AddCommand(builder.BuildGammaLnCommand());
            command.AddCommand(builder.BuildGaussCommand());
            command.AddCommand(builder.BuildGcdCommand());
            command.AddCommand(builder.BuildGeoMeanCommand());
            command.AddCommand(builder.BuildGeStepCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildHarMeanCommand());
            command.AddCommand(builder.BuildHex2BinCommand());
            command.AddCommand(builder.BuildHex2DecCommand());
            command.AddCommand(builder.BuildHex2OctCommand());
            command.AddCommand(builder.BuildHlookupCommand());
            command.AddCommand(builder.BuildHourCommand());
            command.AddCommand(builder.BuildHyperlinkCommand());
            command.AddCommand(builder.BuildHypGeom_DistCommand());
            command.AddCommand(builder.BuildIfCommand());
            command.AddCommand(builder.BuildImAbsCommand());
            command.AddCommand(builder.BuildImaginaryCommand());
            command.AddCommand(builder.BuildImArgumentCommand());
            command.AddCommand(builder.BuildImConjugateCommand());
            command.AddCommand(builder.BuildImCosCommand());
            command.AddCommand(builder.BuildImCoshCommand());
            command.AddCommand(builder.BuildImCotCommand());
            command.AddCommand(builder.BuildImCscCommand());
            command.AddCommand(builder.BuildImCschCommand());
            command.AddCommand(builder.BuildImDivCommand());
            command.AddCommand(builder.BuildImExpCommand());
            command.AddCommand(builder.BuildImLnCommand());
            command.AddCommand(builder.BuildImLog10Command());
            command.AddCommand(builder.BuildImLog2Command());
            command.AddCommand(builder.BuildImPowerCommand());
            command.AddCommand(builder.BuildImProductCommand());
            command.AddCommand(builder.BuildImRealCommand());
            command.AddCommand(builder.BuildImSecCommand());
            command.AddCommand(builder.BuildImSechCommand());
            command.AddCommand(builder.BuildImSinCommand());
            command.AddCommand(builder.BuildImSinhCommand());
            command.AddCommand(builder.BuildImSqrtCommand());
            command.AddCommand(builder.BuildImSubCommand());
            command.AddCommand(builder.BuildImSumCommand());
            command.AddCommand(builder.BuildImTanCommand());
            command.AddCommand(builder.BuildIntCommand());
            command.AddCommand(builder.BuildIntRateCommand());
            command.AddCommand(builder.BuildIpmtCommand());
            command.AddCommand(builder.BuildIrrCommand());
            command.AddCommand(builder.BuildIsErrCommand());
            command.AddCommand(builder.BuildIsErrorCommand());
            command.AddCommand(builder.BuildIsEvenCommand());
            command.AddCommand(builder.BuildIsFormulaCommand());
            command.AddCommand(builder.BuildIsLogicalCommand());
            command.AddCommand(builder.BuildIsNACommand());
            command.AddCommand(builder.BuildIsNonTextCommand());
            command.AddCommand(builder.BuildIsNumberCommand());
            command.AddCommand(builder.BuildIso_CeilingCommand());
            command.AddCommand(builder.BuildIsOddCommand());
            command.AddCommand(builder.BuildIsoWeekNumCommand());
            command.AddCommand(builder.BuildIspmtCommand());
            command.AddCommand(builder.BuildIsrefCommand());
            command.AddCommand(builder.BuildIsTextCommand());
            command.AddCommand(builder.BuildKurtCommand());
            command.AddCommand(builder.BuildLargeCommand());
            command.AddCommand(builder.BuildLcmCommand());
            command.AddCommand(builder.BuildLeftbCommand());
            command.AddCommand(builder.BuildLeftCommand());
            command.AddCommand(builder.BuildLenbCommand());
            command.AddCommand(builder.BuildLenCommand());
            command.AddCommand(builder.BuildLnCommand());
            command.AddCommand(builder.BuildLog10Command());
            command.AddCommand(builder.BuildLogCommand());
            command.AddCommand(builder.BuildLogNorm_DistCommand());
            command.AddCommand(builder.BuildLogNorm_InvCommand());
            command.AddCommand(builder.BuildLookupCommand());
            command.AddCommand(builder.BuildLowerCommand());
            command.AddCommand(builder.BuildMatchCommand());
            command.AddCommand(builder.BuildMaxACommand());
            command.AddCommand(builder.BuildMaxCommand());
            command.AddCommand(builder.BuildMdurationCommand());
            command.AddCommand(builder.BuildMedianCommand());
            command.AddCommand(builder.BuildMidbCommand());
            command.AddCommand(builder.BuildMidCommand());
            command.AddCommand(builder.BuildMinACommand());
            command.AddCommand(builder.BuildMinCommand());
            command.AddCommand(builder.BuildMinuteCommand());
            command.AddCommand(builder.BuildMirrCommand());
            command.AddCommand(builder.BuildModCommand());
            command.AddCommand(builder.BuildMonthCommand());
            command.AddCommand(builder.BuildMroundCommand());
            command.AddCommand(builder.BuildMultiNomialCommand());
            command.AddCommand(builder.BuildNaCommand());
            command.AddCommand(builder.BuildNCommand());
            command.AddCommand(builder.BuildNegBinom_DistCommand());
            command.AddCommand(builder.BuildNetworkDays_IntlCommand());
            command.AddCommand(builder.BuildNetworkDaysCommand());
            command.AddCommand(builder.BuildNominalCommand());
            command.AddCommand(builder.BuildNorm_DistCommand());
            command.AddCommand(builder.BuildNorm_InvCommand());
            command.AddCommand(builder.BuildNorm_S_DistCommand());
            command.AddCommand(builder.BuildNorm_S_InvCommand());
            command.AddCommand(builder.BuildNotCommand());
            command.AddCommand(builder.BuildNowCommand());
            command.AddCommand(builder.BuildNperCommand());
            command.AddCommand(builder.BuildNpvCommand());
            command.AddCommand(builder.BuildNumberValueCommand());
            command.AddCommand(builder.BuildOct2BinCommand());
            command.AddCommand(builder.BuildOct2DecCommand());
            command.AddCommand(builder.BuildOct2HexCommand());
            command.AddCommand(builder.BuildOddCommand());
            command.AddCommand(builder.BuildOddFPriceCommand());
            command.AddCommand(builder.BuildOddFYieldCommand());
            command.AddCommand(builder.BuildOddLPriceCommand());
            command.AddCommand(builder.BuildOddLYieldCommand());
            command.AddCommand(builder.BuildOrCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPdurationCommand());
            command.AddCommand(builder.BuildPercentile_ExcCommand());
            command.AddCommand(builder.BuildPercentile_IncCommand());
            command.AddCommand(builder.BuildPercentRank_ExcCommand());
            command.AddCommand(builder.BuildPercentRank_IncCommand());
            command.AddCommand(builder.BuildPermutationaCommand());
            command.AddCommand(builder.BuildPermutCommand());
            command.AddCommand(builder.BuildPhiCommand());
            command.AddCommand(builder.BuildPiCommand());
            command.AddCommand(builder.BuildPmtCommand());
            command.AddCommand(builder.BuildPoisson_DistCommand());
            command.AddCommand(builder.BuildPowerCommand());
            command.AddCommand(builder.BuildPpmtCommand());
            command.AddCommand(builder.BuildPriceCommand());
            command.AddCommand(builder.BuildPriceDiscCommand());
            command.AddCommand(builder.BuildPriceMatCommand());
            command.AddCommand(builder.BuildProductCommand());
            command.AddCommand(builder.BuildProperCommand());
            command.AddCommand(builder.BuildPvCommand());
            command.AddCommand(builder.BuildQuartile_ExcCommand());
            command.AddCommand(builder.BuildQuartile_IncCommand());
            command.AddCommand(builder.BuildQuotientCommand());
            command.AddCommand(builder.BuildRadiansCommand());
            command.AddCommand(builder.BuildRandBetweenCommand());
            command.AddCommand(builder.BuildRandCommand());
            command.AddCommand(builder.BuildRank_AvgCommand());
            command.AddCommand(builder.BuildRank_EqCommand());
            command.AddCommand(builder.BuildRateCommand());
            command.AddCommand(builder.BuildReceivedCommand());
            command.AddCommand(builder.BuildReplaceBCommand());
            command.AddCommand(builder.BuildReplaceCommand());
            command.AddCommand(builder.BuildReptCommand());
            command.AddCommand(builder.BuildRightbCommand());
            command.AddCommand(builder.BuildRightCommand());
            command.AddCommand(builder.BuildRomanCommand());
            command.AddCommand(builder.BuildRoundCommand());
            command.AddCommand(builder.BuildRoundDownCommand());
            command.AddCommand(builder.BuildRoundUpCommand());
            command.AddCommand(builder.BuildRowsCommand());
            command.AddCommand(builder.BuildRriCommand());
            command.AddCommand(builder.BuildSecCommand());
            command.AddCommand(builder.BuildSechCommand());
            command.AddCommand(builder.BuildSecondCommand());
            command.AddCommand(builder.BuildSeriesSumCommand());
            command.AddCommand(builder.BuildSheetCommand());
            command.AddCommand(builder.BuildSheetsCommand());
            command.AddCommand(builder.BuildSignCommand());
            command.AddCommand(builder.BuildSinCommand());
            command.AddCommand(builder.BuildSinhCommand());
            command.AddCommand(builder.BuildSkew_pCommand());
            command.AddCommand(builder.BuildSkewCommand());
            command.AddCommand(builder.BuildSlnCommand());
            command.AddCommand(builder.BuildSmallCommand());
            command.AddCommand(builder.BuildSqrtCommand());
            command.AddCommand(builder.BuildSqrtPiCommand());
            command.AddCommand(builder.BuildStandardizeCommand());
            command.AddCommand(builder.BuildStDev_PCommand());
            command.AddCommand(builder.BuildStDev_SCommand());
            command.AddCommand(builder.BuildStDevACommand());
            command.AddCommand(builder.BuildStDevPACommand());
            command.AddCommand(builder.BuildSubstituteCommand());
            command.AddCommand(builder.BuildSubtotalCommand());
            command.AddCommand(builder.BuildSumCommand());
            command.AddCommand(builder.BuildSumIfCommand());
            command.AddCommand(builder.BuildSumIfsCommand());
            command.AddCommand(builder.BuildSumSqCommand());
            command.AddCommand(builder.BuildSydCommand());
            command.AddCommand(builder.BuildT_Dist_2TCommand());
            command.AddCommand(builder.BuildT_Dist_RTCommand());
            command.AddCommand(builder.BuildT_DistCommand());
            command.AddCommand(builder.BuildT_Inv_2TCommand());
            command.AddCommand(builder.BuildT_InvCommand());
            command.AddCommand(builder.BuildTanCommand());
            command.AddCommand(builder.BuildTanhCommand());
            command.AddCommand(builder.BuildTbillEqCommand());
            command.AddCommand(builder.BuildTbillPriceCommand());
            command.AddCommand(builder.BuildTbillYieldCommand());
            command.AddCommand(builder.BuildTCommand());
            command.AddCommand(builder.BuildTextCommand());
            command.AddCommand(builder.BuildTimeCommand());
            command.AddCommand(builder.BuildTimevalueCommand());
            command.AddCommand(builder.BuildTodayCommand());
            command.AddCommand(builder.BuildTrimCommand());
            command.AddCommand(builder.BuildTrimMeanCommand());
            command.AddCommand(builder.BuildTrueCommand());
            command.AddCommand(builder.BuildTruncCommand());
            command.AddCommand(builder.BuildTypeCommand());
            command.AddCommand(builder.BuildUnicharCommand());
            command.AddCommand(builder.BuildUnicodeCommand());
            command.AddCommand(builder.BuildUpperCommand());
            command.AddCommand(builder.BuildUsdollarCommand());
            command.AddCommand(builder.BuildValueCommand());
            command.AddCommand(builder.BuildVar_PCommand());
            command.AddCommand(builder.BuildVar_SCommand());
            command.AddCommand(builder.BuildVarACommand());
            command.AddCommand(builder.BuildVarPACommand());
            command.AddCommand(builder.BuildVdbCommand());
            command.AddCommand(builder.BuildVlookupCommand());
            command.AddCommand(builder.BuildWeekdayCommand());
            command.AddCommand(builder.BuildWeekNumCommand());
            command.AddCommand(builder.BuildWeibull_DistCommand());
            command.AddCommand(builder.BuildWorkDay_IntlCommand());
            command.AddCommand(builder.BuildWorkDayCommand());
            command.AddCommand(builder.BuildXirrCommand());
            command.AddCommand(builder.BuildXnpvCommand());
            command.AddCommand(builder.BuildXorCommand());
            command.AddCommand(builder.BuildYearCommand());
            command.AddCommand(builder.BuildYearFracCommand());
            command.AddCommand(builder.BuildYieldCommand());
            command.AddCommand(builder.BuildYieldDiscCommand());
            command.AddCommand(builder.BuildYieldMatCommand());
            command.AddCommand(builder.BuildZ_TestCommand());
            return command;
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--driveitem-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            command.SetHandler(async (string driveItemId, string[] expand, FormatterType output, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response, console);
            }, driveItemIdOption, expandOption, outputOption);
            return command;
        }
        public Command BuildNamesCommand() {
            var command = new Command("names");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Names.NamesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAddCommand());
            command.AddCommand(builder.BuildAddFormulaLocalCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildOperationsCommand() {
            var command = new Command("operations");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Operations.OperationsRequestBuilder(PathParameters, RequestAdapter);
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--driveitem-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (string driveItemId, string body, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Workbook>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                console.WriteLine("Success");
            }, driveItemIdOption, bodyOption);
            return command;
        }
        public Command BuildRefreshSessionCommand() {
            var command = new Command("refresh-session");
            var builder = new ApiSdk.Workbooks.Item.Workbook.RefreshSession.RefreshSessionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTablesCommand() {
            var command = new Command("tables");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.TablesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAddCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        public Command BuildWorksheetsCommand() {
            var command = new Command("worksheets");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Worksheets.WorksheetsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildAddCommand());
            foreach (var cmd in builder.BuildCommand()) {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new WorkbookRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WorkbookRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook{?expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new WorkbookRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WorkbookRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook{?expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.Workbook body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApiSdk.Models.Microsoft.Graph.Workbook> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.Workbook>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ApiSdk.Models.Microsoft.Graph.Workbook model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\microsoft.graph.sessionInfoResource(key='{key}')
        /// <param name="key">Usage: key={key}</param>
        /// </summary>
        public SessionInfoResourceWithKeyRequestBuilder SessionInfoResourceWithKey(string key) {
            if(string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
            return new SessionInfoResourceWithKeyRequestBuilder(PathParameters, RequestAdapter, key);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\microsoft.graph.tableRowOperationResult(key='{key}')
        /// <param name="key">Usage: key={key}</param>
        /// </summary>
        public TableRowOperationResultWithKeyRequestBuilder TableRowOperationResultWithKey(string key) {
            if(string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
            return new TableRowOperationResultWithKeyRequestBuilder(PathParameters, RequestAdapter, key);
        }
        /// <summary>For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
        }
    }
}
