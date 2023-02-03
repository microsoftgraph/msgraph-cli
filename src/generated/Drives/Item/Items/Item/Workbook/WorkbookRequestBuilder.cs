using ApiSdk.Drives.Item.Items.Item.Workbook.Application;
using ApiSdk.Drives.Item.Items.Item.Workbook.Comments;
using ApiSdk.Drives.Item.Items.Item.Workbook.Functions;
using ApiSdk.Drives.Item.Items.Item.Workbook.MicrosoftGraphCloseSession;
using ApiSdk.Drives.Item.Items.Item.Workbook.MicrosoftGraphCreateSession;
using ApiSdk.Drives.Item.Items.Item.Workbook.MicrosoftGraphRefreshSession;
using ApiSdk.Drives.Item.Items.Item.Workbook.MicrosoftGraphSessionInfoResourceWithKey;
using ApiSdk.Drives.Item.Items.Item.Workbook.MicrosoftGraphTableRowOperationResultWithKey;
using ApiSdk.Drives.Item.Items.Item.Workbook.Names;
using ApiSdk.Drives.Item.Items.Item.Workbook.Operations;
using ApiSdk.Drives.Item.Items.Item.Workbook.Tables;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets;
using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
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
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the application property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildApplicationCommand() {
            var command = new Command("application");
            command.Description = "Provides operations to manage the application property of the microsoft.graph.workbook entity.";
            var builder = new ApplicationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCalculateCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the comments property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildCommentsCommand() {
            var command = new Command("comments");
            command.Description = "Provides operations to manage the comments property of the microsoft.graph.workbook entity.";
            var builder = new CommentsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Delete navigation property workbook for drives
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property workbook for drives";
            // Create options for all the parameters
            var driveIdOption = new Option<string>("--drive-id", description: "key: id of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "key: id of driveItem") {
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
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (driveId is not null) requestInfo.PathParameters.Add("drive%2Did", driveId);
                if (driveItemId is not null) requestInfo.PathParameters.Add("driveItem%2Did", driveItemId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
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
            var builder = new FunctionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAbsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAccrIntCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAccrIntMCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAcosCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAcoshCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAcotCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAcothCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAmorDegrcCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAmorLincCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAndCommand());
            command.AddCommand(builder.BuildMicrosoftGraphArabicCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAreasCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAscCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAsinCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAsinhCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAtan2Command());
            command.AddCommand(builder.BuildMicrosoftGraphAtanCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAtanhCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAveDevCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAverageACommand());
            command.AddCommand(builder.BuildMicrosoftGraphAverageCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAverageIfCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAverageIfsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBahtTextCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBaseCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBesselICommand());
            command.AddCommand(builder.BuildMicrosoftGraphBesselJCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBesselKCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBesselYCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBeta_DistCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBeta_InvCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBin2DecCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBin2HexCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBin2OctCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBinom_Dist_RangeCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBinom_DistCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBinom_InvCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBitandCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBitlshiftCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBitorCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBitrshiftCommand());
            command.AddCommand(builder.BuildMicrosoftGraphBitxorCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCeiling_MathCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCeiling_PreciseCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCharCommand());
            command.AddCommand(builder.BuildMicrosoftGraphChiSq_Dist_RTCommand());
            command.AddCommand(builder.BuildMicrosoftGraphChiSq_DistCommand());
            command.AddCommand(builder.BuildMicrosoftGraphChiSq_Inv_RTCommand());
            command.AddCommand(builder.BuildMicrosoftGraphChiSq_InvCommand());
            command.AddCommand(builder.BuildMicrosoftGraphChooseCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCleanCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCodeCommand());
            command.AddCommand(builder.BuildMicrosoftGraphColumnsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCombinaCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCombinCommand());
            command.AddCommand(builder.BuildMicrosoftGraphComplexCommand());
            command.AddCommand(builder.BuildMicrosoftGraphConcatenateCommand());
            command.AddCommand(builder.BuildMicrosoftGraphConfidence_NormCommand());
            command.AddCommand(builder.BuildMicrosoftGraphConfidence_TCommand());
            command.AddCommand(builder.BuildMicrosoftGraphConvertCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCosCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCoshCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCotCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCothCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCountACommand());
            command.AddCommand(builder.BuildMicrosoftGraphCountBlankCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCountCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCountIfCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCountIfsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCoupDayBsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCoupDaysCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCoupDaysNcCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCoupNcdCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCoupNumCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCoupPcdCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCscCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCschCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCumIPmtCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCumPrincCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDateCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDatevalueCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDaverageCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDayCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDays360Command());
            command.AddCommand(builder.BuildMicrosoftGraphDaysCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDbCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDbcsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDcountACommand());
            command.AddCommand(builder.BuildMicrosoftGraphDcountCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDdbCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDec2BinCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDec2HexCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDec2OctCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDecimalCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDegreesCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDevSqCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDgetCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDiscCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDmaxCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDminCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDollarCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDollarDeCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDollarFrCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDproductCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDstDevCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDstDevPCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDsumCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDurationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDvarCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDvarPCommand());
            command.AddCommand(builder.BuildMicrosoftGraphEcma_CeilingCommand());
            command.AddCommand(builder.BuildMicrosoftGraphEdateCommand());
            command.AddCommand(builder.BuildMicrosoftGraphEffectCommand());
            command.AddCommand(builder.BuildMicrosoftGraphEoMonthCommand());
            command.AddCommand(builder.BuildMicrosoftGraphErf_PreciseCommand());
            command.AddCommand(builder.BuildMicrosoftGraphErfC_PreciseCommand());
            command.AddCommand(builder.BuildMicrosoftGraphErfCCommand());
            command.AddCommand(builder.BuildMicrosoftGraphErfCommand());
            command.AddCommand(builder.BuildMicrosoftGraphError_TypeCommand());
            command.AddCommand(builder.BuildMicrosoftGraphEvenCommand());
            command.AddCommand(builder.BuildMicrosoftGraphExactCommand());
            command.AddCommand(builder.BuildMicrosoftGraphExpCommand());
            command.AddCommand(builder.BuildMicrosoftGraphExpon_DistCommand());
            command.AddCommand(builder.BuildMicrosoftGraphF_Dist_RTCommand());
            command.AddCommand(builder.BuildMicrosoftGraphF_DistCommand());
            command.AddCommand(builder.BuildMicrosoftGraphF_Inv_RTCommand());
            command.AddCommand(builder.BuildMicrosoftGraphF_InvCommand());
            command.AddCommand(builder.BuildMicrosoftGraphFactCommand());
            command.AddCommand(builder.BuildMicrosoftGraphFactDoubleCommand());
            command.AddCommand(builder.BuildMicrosoftGraphFalseCommand());
            command.AddCommand(builder.BuildMicrosoftGraphFindBCommand());
            command.AddCommand(builder.BuildMicrosoftGraphFindCommand());
            command.AddCommand(builder.BuildMicrosoftGraphFisherCommand());
            command.AddCommand(builder.BuildMicrosoftGraphFisherInvCommand());
            command.AddCommand(builder.BuildMicrosoftGraphFixedCommand());
            command.AddCommand(builder.BuildMicrosoftGraphFloor_MathCommand());
            command.AddCommand(builder.BuildMicrosoftGraphFloor_PreciseCommand());
            command.AddCommand(builder.BuildMicrosoftGraphFvCommand());
            command.AddCommand(builder.BuildMicrosoftGraphFvscheduleCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGamma_DistCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGamma_InvCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGammaCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGammaLn_PreciseCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGammaLnCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGaussCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGcdCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGeoMeanCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGeStepCommand());
            command.AddCommand(builder.BuildMicrosoftGraphHarMeanCommand());
            command.AddCommand(builder.BuildMicrosoftGraphHex2BinCommand());
            command.AddCommand(builder.BuildMicrosoftGraphHex2DecCommand());
            command.AddCommand(builder.BuildMicrosoftGraphHex2OctCommand());
            command.AddCommand(builder.BuildMicrosoftGraphHlookupCommand());
            command.AddCommand(builder.BuildMicrosoftGraphHourCommand());
            command.AddCommand(builder.BuildMicrosoftGraphHyperlinkCommand());
            command.AddCommand(builder.BuildMicrosoftGraphHypGeom_DistCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIfCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImAbsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImaginaryCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImArgumentCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImConjugateCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImCosCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImCoshCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImCotCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImCscCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImCschCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImDivCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImExpCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImLnCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImLog10Command());
            command.AddCommand(builder.BuildMicrosoftGraphImLog2Command());
            command.AddCommand(builder.BuildMicrosoftGraphImPowerCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImProductCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImRealCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImSecCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImSechCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImSinCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImSinhCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImSqrtCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImSubCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImSumCommand());
            command.AddCommand(builder.BuildMicrosoftGraphImTanCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIntCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIntRateCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIpmtCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIrrCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIsErrCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIsErrorCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIsEvenCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIsFormulaCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIsLogicalCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIsNACommand());
            command.AddCommand(builder.BuildMicrosoftGraphIsNonTextCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIsNumberCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIso_CeilingCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIsOddCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIsoWeekNumCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIspmtCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIsrefCommand());
            command.AddCommand(builder.BuildMicrosoftGraphIsTextCommand());
            command.AddCommand(builder.BuildMicrosoftGraphKurtCommand());
            command.AddCommand(builder.BuildMicrosoftGraphLargeCommand());
            command.AddCommand(builder.BuildMicrosoftGraphLcmCommand());
            command.AddCommand(builder.BuildMicrosoftGraphLeftbCommand());
            command.AddCommand(builder.BuildMicrosoftGraphLeftCommand());
            command.AddCommand(builder.BuildMicrosoftGraphLenbCommand());
            command.AddCommand(builder.BuildMicrosoftGraphLenCommand());
            command.AddCommand(builder.BuildMicrosoftGraphLnCommand());
            command.AddCommand(builder.BuildMicrosoftGraphLog10Command());
            command.AddCommand(builder.BuildMicrosoftGraphLogCommand());
            command.AddCommand(builder.BuildMicrosoftGraphLogNorm_DistCommand());
            command.AddCommand(builder.BuildMicrosoftGraphLogNorm_InvCommand());
            command.AddCommand(builder.BuildMicrosoftGraphLookupCommand());
            command.AddCommand(builder.BuildMicrosoftGraphLowerCommand());
            command.AddCommand(builder.BuildMicrosoftGraphMatchCommand());
            command.AddCommand(builder.BuildMicrosoftGraphMaxACommand());
            command.AddCommand(builder.BuildMicrosoftGraphMaxCommand());
            command.AddCommand(builder.BuildMicrosoftGraphMdurationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphMedianCommand());
            command.AddCommand(builder.BuildMicrosoftGraphMidbCommand());
            command.AddCommand(builder.BuildMicrosoftGraphMidCommand());
            command.AddCommand(builder.BuildMicrosoftGraphMinACommand());
            command.AddCommand(builder.BuildMicrosoftGraphMinCommand());
            command.AddCommand(builder.BuildMicrosoftGraphMinuteCommand());
            command.AddCommand(builder.BuildMicrosoftGraphMirrCommand());
            command.AddCommand(builder.BuildMicrosoftGraphModCommand());
            command.AddCommand(builder.BuildMicrosoftGraphMonthCommand());
            command.AddCommand(builder.BuildMicrosoftGraphMroundCommand());
            command.AddCommand(builder.BuildMicrosoftGraphMultiNomialCommand());
            command.AddCommand(builder.BuildMicrosoftGraphNaCommand());
            command.AddCommand(builder.BuildMicrosoftGraphNCommand());
            command.AddCommand(builder.BuildMicrosoftGraphNegBinom_DistCommand());
            command.AddCommand(builder.BuildMicrosoftGraphNetworkDays_IntlCommand());
            command.AddCommand(builder.BuildMicrosoftGraphNetworkDaysCommand());
            command.AddCommand(builder.BuildMicrosoftGraphNominalCommand());
            command.AddCommand(builder.BuildMicrosoftGraphNorm_DistCommand());
            command.AddCommand(builder.BuildMicrosoftGraphNorm_InvCommand());
            command.AddCommand(builder.BuildMicrosoftGraphNorm_S_DistCommand());
            command.AddCommand(builder.BuildMicrosoftGraphNorm_S_InvCommand());
            command.AddCommand(builder.BuildMicrosoftGraphNotCommand());
            command.AddCommand(builder.BuildMicrosoftGraphNowCommand());
            command.AddCommand(builder.BuildMicrosoftGraphNperCommand());
            command.AddCommand(builder.BuildMicrosoftGraphNpvCommand());
            command.AddCommand(builder.BuildMicrosoftGraphNumberValueCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOct2BinCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOct2DecCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOct2HexCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOddCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOddFPriceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOddFYieldCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOddLPriceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOddLYieldCommand());
            command.AddCommand(builder.BuildMicrosoftGraphOrCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPdurationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPercentile_ExcCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPercentile_IncCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPercentRank_ExcCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPercentRank_IncCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPermutationaCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPermutCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPhiCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPiCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPmtCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPoisson_DistCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPowerCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPpmtCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPriceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPriceDiscCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPriceMatCommand());
            command.AddCommand(builder.BuildMicrosoftGraphProductCommand());
            command.AddCommand(builder.BuildMicrosoftGraphProperCommand());
            command.AddCommand(builder.BuildMicrosoftGraphPvCommand());
            command.AddCommand(builder.BuildMicrosoftGraphQuartile_ExcCommand());
            command.AddCommand(builder.BuildMicrosoftGraphQuartile_IncCommand());
            command.AddCommand(builder.BuildMicrosoftGraphQuotientCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRadiansCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRandBetweenCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRandCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRank_AvgCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRank_EqCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRateCommand());
            command.AddCommand(builder.BuildMicrosoftGraphReceivedCommand());
            command.AddCommand(builder.BuildMicrosoftGraphReplaceBCommand());
            command.AddCommand(builder.BuildMicrosoftGraphReplaceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphReptCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRightbCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRightCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRomanCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRoundCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRoundDownCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRoundUpCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRowsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphRriCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSecCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSechCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSecondCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSeriesSumCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSheetCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSheetsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSignCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSinCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSinhCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSkew_pCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSkewCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSlnCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSmallCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSqrtCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSqrtPiCommand());
            command.AddCommand(builder.BuildMicrosoftGraphStandardizeCommand());
            command.AddCommand(builder.BuildMicrosoftGraphStDev_PCommand());
            command.AddCommand(builder.BuildMicrosoftGraphStDev_SCommand());
            command.AddCommand(builder.BuildMicrosoftGraphStDevACommand());
            command.AddCommand(builder.BuildMicrosoftGraphStDevPACommand());
            command.AddCommand(builder.BuildMicrosoftGraphSubstituteCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSubtotalCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSumCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSumIfCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSumIfsCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSumSqCommand());
            command.AddCommand(builder.BuildMicrosoftGraphSydCommand());
            command.AddCommand(builder.BuildMicrosoftGraphT_Dist_2TCommand());
            command.AddCommand(builder.BuildMicrosoftGraphT_Dist_RTCommand());
            command.AddCommand(builder.BuildMicrosoftGraphT_DistCommand());
            command.AddCommand(builder.BuildMicrosoftGraphT_Inv_2TCommand());
            command.AddCommand(builder.BuildMicrosoftGraphT_InvCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTanCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTanhCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTbillEqCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTbillPriceCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTbillYieldCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTextCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTimeCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTimevalueCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTodayCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTrimCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTrimMeanCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTrueCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTruncCommand());
            command.AddCommand(builder.BuildMicrosoftGraphTypeCommand());
            command.AddCommand(builder.BuildMicrosoftGraphUnicharCommand());
            command.AddCommand(builder.BuildMicrosoftGraphUnicodeCommand());
            command.AddCommand(builder.BuildMicrosoftGraphUpperCommand());
            command.AddCommand(builder.BuildMicrosoftGraphUsdollarCommand());
            command.AddCommand(builder.BuildMicrosoftGraphValueCommand());
            command.AddCommand(builder.BuildMicrosoftGraphVar_PCommand());
            command.AddCommand(builder.BuildMicrosoftGraphVar_SCommand());
            command.AddCommand(builder.BuildMicrosoftGraphVarACommand());
            command.AddCommand(builder.BuildMicrosoftGraphVarPACommand());
            command.AddCommand(builder.BuildMicrosoftGraphVdbCommand());
            command.AddCommand(builder.BuildMicrosoftGraphVlookupCommand());
            command.AddCommand(builder.BuildMicrosoftGraphWeekdayCommand());
            command.AddCommand(builder.BuildMicrosoftGraphWeekNumCommand());
            command.AddCommand(builder.BuildMicrosoftGraphWeibull_DistCommand());
            command.AddCommand(builder.BuildMicrosoftGraphWorkDay_IntlCommand());
            command.AddCommand(builder.BuildMicrosoftGraphWorkDayCommand());
            command.AddCommand(builder.BuildMicrosoftGraphXirrCommand());
            command.AddCommand(builder.BuildMicrosoftGraphXnpvCommand());
            command.AddCommand(builder.BuildMicrosoftGraphXorCommand());
            command.AddCommand(builder.BuildMicrosoftGraphYearCommand());
            command.AddCommand(builder.BuildMicrosoftGraphYearFracCommand());
            command.AddCommand(builder.BuildMicrosoftGraphYieldCommand());
            command.AddCommand(builder.BuildMicrosoftGraphYieldDiscCommand());
            command.AddCommand(builder.BuildMicrosoftGraphYieldMatCommand());
            command.AddCommand(builder.BuildMicrosoftGraphZ_TestCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet&apos;s contents. Nullable.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.";
            // Create options for all the parameters
            var driveIdOption = new Option<string>("--drive-id", description: "key: id of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "key: id of driveItem") {
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
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the closeSession method.
        /// </summary>
        public Command BuildMicrosoftGraphCloseSessionCommand() {
            var command = new Command("microsoft-graph-close-session");
            command.Description = "Provides operations to call the closeSession method.";
            var builder = new CloseSessionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the createSession method.
        /// </summary>
        public Command BuildMicrosoftGraphCreateSessionCommand() {
            var command = new Command("microsoft-graph-create-session");
            command.Description = "Provides operations to call the createSession method.";
            var builder = new CreateSessionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the refreshSession method.
        /// </summary>
        public Command BuildMicrosoftGraphRefreshSessionCommand() {
            var command = new Command("microsoft-graph-refresh-session");
            command.Description = "Provides operations to call the refreshSession method.";
            var builder = new RefreshSessionRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the names property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildNamesCommand() {
            var command = new Command("names");
            command.Description = "Provides operations to manage the names property of the microsoft.graph.workbook entity.";
            var builder = new NamesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAddCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAddFormulaLocalCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the operations property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildOperationsCommand() {
            var command = new Command("operations");
            command.Description = "Provides operations to manage the operations property of the microsoft.graph.workbook entity.";
            var builder = new OperationsRequestBuilder(PathParameters, RequestAdapter);
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
            var driveIdOption = new Option<string>("--drive-id", description: "key: id of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "key: id of driveItem") {
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
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Workbook>(ApiSdk.Models.Workbook.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (driveId is not null) requestInfo.PathParameters.Add("drive%2Did", driveId);
                if (driveItemId is not null) requestInfo.PathParameters.Add("driveItem%2Did", driveItemId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the tables property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildTablesCommand() {
            var command = new Command("tables");
            command.Description = "Provides operations to manage the tables property of the microsoft.graph.workbook entity.";
            var builder = new TablesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAddCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCountCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the worksheets property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildWorksheetsCommand() {
            var command = new Command("worksheets");
            command.Description = "Provides operations to manage the worksheets property of the microsoft.graph.workbook entity.";
            var builder = new WorksheetsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAddCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new WorkbookRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkbookRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Provides operations to call the sessionInfoResource method.
        /// </summary>
        /// <param name="key">Usage: key=&apos;{key}&apos;</param>
        public SessionInfoResourceWithKeyRequestBuilder MicrosoftGraphSessionInfoResourceWithKey(string key) {
            if(string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
            return new SessionInfoResourceWithKeyRequestBuilder(PathParameters, RequestAdapter, key);
        }
        /// <summary>
        /// Provides operations to call the tableRowOperationResult method.
        /// </summary>
        /// <param name="key">Usage: key=&apos;{key}&apos;</param>
        public TableRowOperationResultWithKeyRequestBuilder MicrosoftGraphTableRowOperationResultWithKey(string key) {
            if(string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
            return new TableRowOperationResultWithKeyRequestBuilder(PathParameters, RequestAdapter, key);
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
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
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
