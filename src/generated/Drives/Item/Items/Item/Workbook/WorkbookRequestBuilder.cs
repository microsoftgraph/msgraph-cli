using ApiSdk.Drives.Item.Items.Item.Workbook.Application;
using ApiSdk.Drives.Item.Items.Item.Workbook.CloseSession;
using ApiSdk.Drives.Item.Items.Item.Workbook.Comments;
using ApiSdk.Drives.Item.Items.Item.Workbook.CreateSession;
using ApiSdk.Drives.Item.Items.Item.Workbook.Functions;
using ApiSdk.Drives.Item.Items.Item.Workbook.Names;
using ApiSdk.Drives.Item.Items.Item.Workbook.Operations;
using ApiSdk.Drives.Item.Items.Item.Workbook.RefreshSession;
using ApiSdk.Drives.Item.Items.Item.Workbook.SessionInfoResourceWithKey;
using ApiSdk.Drives.Item.Items.Item.Workbook.TableRowOperationResultWithKey;
using ApiSdk.Drives.Item.Items.Item.Workbook.Tables;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets;
using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Drives.Item.Items.Item.Workbook {
    /// <summary>
    /// Provides operations to manage the workbook property of the microsoft.graph.driveItem entity.
    /// </summary>
    public class WorkbookRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the application property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildApplicationCommand() {
            var command = new Command("application");
            command.Description = "Provides operations to manage the application property of the microsoft.graph.workbook entity.";
            var builder = new ApplicationRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCalculateCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the closeSession method.
        /// </summary>
        public Command BuildCloseSessionCommand() {
            var command = new Command("close-session");
            command.Description = "Provides operations to call the closeSession method.";
            var builder = new CloseSessionRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the comments property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildCommentsCommand() {
            var command = new Command("comments");
            command.Description = "Provides operations to manage the comments property of the microsoft.graph.workbook entity.";
            var builder = new CommentsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the createSession method.
        /// </summary>
        public Command BuildCreateSessionCommand() {
            var command = new Command("create-session");
            command.Description = "Provides operations to call the createSession method.";
            var builder = new CreateSessionRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Delete navigation property workbook for drives
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property workbook for drives";
            // Create options for all the parameters
            var driveIdOption = new Option<string>("--drive-id", description: "The unique identifier of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "The unique identifier of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var driveId = invocationContext.ParseResult.GetValueForOption(driveIdOption);
                var driveItemId = invocationContext.ParseResult.GetValueForOption(driveItemIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (driveId is not null) requestInfo.PathParameters.Add("drive%2Did", driveId);
                if (driveItemId is not null) requestInfo.PathParameters.Add("driveItem%2Did", driveItemId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the functions property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildFunctionsCommand() {
            var command = new Command("functions");
            command.Description = "Provides operations to manage the functions property of the microsoft.graph.workbook entity.";
            var builder = new FunctionsRequestBuilder(PathParameters);
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
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet&apos;s contents. Nullable.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.";
            // Create options for all the parameters
            var driveIdOption = new Option<string>("--drive-id", description: "The unique identifier of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "The unique identifier of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var jsonNoIndentOption = new Option<bool>("--json-no-indent", r => {
                if (bool.TryParse(r.Tokens.Select(t => t.Value).LastOrDefault(), out var value)) {
                    return value;
                }
                return true;
            }, description: "Disable indentation for the JSON output formatter.");
            command.AddOption(jsonNoIndentOption);
            command.SetHandler(async (invocationContext) => {
                var driveId = invocationContext.ParseResult.GetValueForOption(driveIdOption);
                var driveItemId = invocationContext.ParseResult.GetValueForOption(driveItemIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (driveId is not null) requestInfo.PathParameters.Add("drive%2Did", driveId);
                if (driveItemId is not null) requestInfo.PathParameters.Add("driveItem%2Did", driveItemId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the names property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildNamesCommand() {
            var command = new Command("names");
            command.Description = "Provides operations to manage the names property of the microsoft.graph.workbook entity.";
            var builder = new NamesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildAddCommand());
            command.AddCommand(builder.BuildAddFormulaLocalCommand());
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the operations property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildOperationsCommand() {
            var command = new Command("operations");
            command.Description = "Provides operations to manage the operations property of the microsoft.graph.workbook entity.";
            var builder = new OperationsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Update the navigation property workbook in drives
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property workbook in drives";
            // Create options for all the parameters
            var driveIdOption = new Option<string>("--drive-id", description: "The unique identifier of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "The unique identifier of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var jsonNoIndentOption = new Option<bool>("--json-no-indent", r => {
                if (bool.TryParse(r.Tokens.Select(t => t.Value).LastOrDefault(), out var value)) {
                    return value;
                }
                return true;
            }, description: "Disable indentation for the JSON output formatter.");
            command.AddOption(jsonNoIndentOption);
            command.SetHandler(async (invocationContext) => {
                var driveId = invocationContext.ParseResult.GetValueForOption(driveIdOption);
                var driveItemId = invocationContext.ParseResult.GetValueForOption(driveItemIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Workbook>(ApiSdk.Models.Workbook.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (driveId is not null) requestInfo.PathParameters.Add("drive%2Did", driveId);
                if (driveItemId is not null) requestInfo.PathParameters.Add("driveItem%2Did", driveItemId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the refreshSession method.
        /// </summary>
        public Command BuildRefreshSessionCommand() {
            var command = new Command("refresh-session");
            command.Description = "Provides operations to call the refreshSession method.";
            var builder = new RefreshSessionRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the tables property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildTablesCommand() {
            var command = new Command("tables");
            command.Description = "Provides operations to manage the tables property of the microsoft.graph.workbook entity.";
            var builder = new TablesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildAddCommand());
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the worksheets property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildWorksheetsCommand() {
            var command = new Command("worksheets");
            command.Description = "Provides operations to manage the worksheets property of the microsoft.graph.workbook entity.";
            var builder = new WorksheetsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildAddCommand());
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new WorkbookRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public WorkbookRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Delete navigation property workbook for drives
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<WorkbookRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<WorkbookRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new WorkbookRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet&apos;s contents. Nullable.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WorkbookRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WorkbookRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new WorkbookRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property workbook in drives
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.Workbook body, Action<WorkbookRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.Workbook body, Action<WorkbookRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new WorkbookRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WorkbookRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new workbookRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public WorkbookRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet&apos;s contents. Nullable.
        /// </summary>
        public class WorkbookRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WorkbookRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WorkbookRequestBuilderGetQueryParameters QueryParameters { get; set; } = new WorkbookRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new workbookRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WorkbookRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WorkbookRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new workbookRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public WorkbookRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
