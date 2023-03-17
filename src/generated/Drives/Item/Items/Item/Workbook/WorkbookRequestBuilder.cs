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
        public Command BuildApplicationNavCommand() {
            var command = new Command("application");
            command.Description = "Provides operations to manage the application property of the microsoft.graph.workbook entity.";
            var builder = new ApplicationRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCalculateNavCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildPatchCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the closeSession method.
        /// </summary>
        public Command BuildCloseSessionNavCommand() {
            var command = new Command("close-session");
            command.Description = "Provides operations to call the closeSession method.";
            var builder = new CloseSessionRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the comments property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildCommentsNavCommand() {
            var command = new Command("comments");
            command.Description = "Provides operations to manage the comments property of the microsoft.graph.workbook entity.";
            var builder = new CommentsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the createSession method.
        /// </summary>
        public Command BuildCreateSessionNavCommand() {
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
        public Command BuildFunctionsNavCommand() {
            var command = new Command("functions");
            command.Description = "Provides operations to manage the functions property of the microsoft.graph.workbook entity.";
            var builder = new FunctionsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildAbsNavCommand());
            command.AddCommand(builder.BuildAccrIntMNavCommand());
            command.AddCommand(builder.BuildAccrIntNavCommand());
            command.AddCommand(builder.BuildAcoshNavCommand());
            command.AddCommand(builder.BuildAcosNavCommand());
            command.AddCommand(builder.BuildAcothNavCommand());
            command.AddCommand(builder.BuildAcotNavCommand());
            command.AddCommand(builder.BuildAmorDegrcNavCommand());
            command.AddCommand(builder.BuildAmorLincNavCommand());
            command.AddCommand(builder.BuildAndNavCommand());
            command.AddCommand(builder.BuildArabicNavCommand());
            command.AddCommand(builder.BuildAreasNavCommand());
            command.AddCommand(builder.BuildAscNavCommand());
            command.AddCommand(builder.BuildAsinhNavCommand());
            command.AddCommand(builder.BuildAsinNavCommand());
            command.AddCommand(builder.BuildAtan2NavCommand());
            command.AddCommand(builder.BuildAtanhNavCommand());
            command.AddCommand(builder.BuildAtanNavCommand());
            command.AddCommand(builder.BuildAveDevNavCommand());
            command.AddCommand(builder.BuildAverageANavCommand());
            command.AddCommand(builder.BuildAverageIfNavCommand());
            command.AddCommand(builder.BuildAverageIfsNavCommand());
            command.AddCommand(builder.BuildAverageNavCommand());
            command.AddCommand(builder.BuildBahtTextNavCommand());
            command.AddCommand(builder.BuildBaseNavCommand());
            command.AddCommand(builder.BuildBesselINavCommand());
            command.AddCommand(builder.BuildBesselJNavCommand());
            command.AddCommand(builder.BuildBesselKNavCommand());
            command.AddCommand(builder.BuildBesselYNavCommand());
            command.AddCommand(builder.BuildBeta_DistNavCommand());
            command.AddCommand(builder.BuildBeta_InvNavCommand());
            command.AddCommand(builder.BuildBin2DecNavCommand());
            command.AddCommand(builder.BuildBin2HexNavCommand());
            command.AddCommand(builder.BuildBin2OctNavCommand());
            command.AddCommand(builder.BuildBinom_Dist_RangeNavCommand());
            command.AddCommand(builder.BuildBinom_DistNavCommand());
            command.AddCommand(builder.BuildBinom_InvNavCommand());
            command.AddCommand(builder.BuildBitandNavCommand());
            command.AddCommand(builder.BuildBitlshiftNavCommand());
            command.AddCommand(builder.BuildBitorNavCommand());
            command.AddCommand(builder.BuildBitrshiftNavCommand());
            command.AddCommand(builder.BuildBitxorNavCommand());
            command.AddCommand(builder.BuildCeiling_MathNavCommand());
            command.AddCommand(builder.BuildCeiling_PreciseNavCommand());
            command.AddCommand(builder.BuildCharNavCommand());
            command.AddCommand(builder.BuildChiSq_Dist_RTNavCommand());
            command.AddCommand(builder.BuildChiSq_DistNavCommand());
            command.AddCommand(builder.BuildChiSq_Inv_RTNavCommand());
            command.AddCommand(builder.BuildChiSq_InvNavCommand());
            command.AddCommand(builder.BuildChooseNavCommand());
            command.AddCommand(builder.BuildCleanNavCommand());
            command.AddCommand(builder.BuildCodeNavCommand());
            command.AddCommand(builder.BuildColumnsNavCommand());
            command.AddCommand(builder.BuildCombinaNavCommand());
            command.AddCommand(builder.BuildCombinNavCommand());
            command.AddCommand(builder.BuildComplexNavCommand());
            command.AddCommand(builder.BuildConcatenateNavCommand());
            command.AddCommand(builder.BuildConfidence_NormNavCommand());
            command.AddCommand(builder.BuildConfidence_TNavCommand());
            command.AddCommand(builder.BuildConvertNavCommand());
            command.AddCommand(builder.BuildCoshNavCommand());
            command.AddCommand(builder.BuildCosNavCommand());
            command.AddCommand(builder.BuildCothNavCommand());
            command.AddCommand(builder.BuildCotNavCommand());
            command.AddCommand(builder.BuildCountANavCommand());
            command.AddCommand(builder.BuildCountBlankNavCommand());
            command.AddCommand(builder.BuildCountIfNavCommand());
            command.AddCommand(builder.BuildCountIfsNavCommand());
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCoupDayBsNavCommand());
            command.AddCommand(builder.BuildCoupDaysNavCommand());
            command.AddCommand(builder.BuildCoupDaysNcNavCommand());
            command.AddCommand(builder.BuildCoupNcdNavCommand());
            command.AddCommand(builder.BuildCoupNumNavCommand());
            command.AddCommand(builder.BuildCoupPcdNavCommand());
            command.AddCommand(builder.BuildCschNavCommand());
            command.AddCommand(builder.BuildCscNavCommand());
            command.AddCommand(builder.BuildCumIPmtNavCommand());
            command.AddCommand(builder.BuildCumPrincNavCommand());
            command.AddCommand(builder.BuildDateNavCommand());
            command.AddCommand(builder.BuildDatevalueNavCommand());
            command.AddCommand(builder.BuildDaverageNavCommand());
            command.AddCommand(builder.BuildDayNavCommand());
            command.AddCommand(builder.BuildDays360NavCommand());
            command.AddCommand(builder.BuildDaysNavCommand());
            command.AddCommand(builder.BuildDbcsNavCommand());
            command.AddCommand(builder.BuildDbNavCommand());
            command.AddCommand(builder.BuildDcountANavCommand());
            command.AddCommand(builder.BuildDcountNavCommand());
            command.AddCommand(builder.BuildDdbNavCommand());
            command.AddCommand(builder.BuildDec2BinNavCommand());
            command.AddCommand(builder.BuildDec2HexNavCommand());
            command.AddCommand(builder.BuildDec2OctNavCommand());
            command.AddCommand(builder.BuildDecimalNavCommand());
            command.AddCommand(builder.BuildDegreesNavCommand());
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildDeltaNavCommand());
            command.AddCommand(builder.BuildDevSqNavCommand());
            command.AddCommand(builder.BuildDgetNavCommand());
            command.AddCommand(builder.BuildDiscNavCommand());
            command.AddCommand(builder.BuildDmaxNavCommand());
            command.AddCommand(builder.BuildDminNavCommand());
            command.AddCommand(builder.BuildDollarDeNavCommand());
            command.AddCommand(builder.BuildDollarFrNavCommand());
            command.AddCommand(builder.BuildDollarNavCommand());
            command.AddCommand(builder.BuildDproductNavCommand());
            command.AddCommand(builder.BuildDstDevNavCommand());
            command.AddCommand(builder.BuildDstDevPNavCommand());
            command.AddCommand(builder.BuildDsumNavCommand());
            command.AddCommand(builder.BuildDurationNavCommand());
            command.AddCommand(builder.BuildDvarNavCommand());
            command.AddCommand(builder.BuildDvarPNavCommand());
            command.AddCommand(builder.BuildEcma_CeilingNavCommand());
            command.AddCommand(builder.BuildEdateNavCommand());
            command.AddCommand(builder.BuildEffectNavCommand());
            command.AddCommand(builder.BuildEoMonthNavCommand());
            command.AddCommand(builder.BuildErf_PreciseNavCommand());
            command.AddCommand(builder.BuildErfC_PreciseNavCommand());
            command.AddCommand(builder.BuildErfCNavCommand());
            command.AddCommand(builder.BuildErfNavCommand());
            command.AddCommand(builder.BuildError_TypeNavCommand());
            command.AddCommand(builder.BuildEvenNavCommand());
            command.AddCommand(builder.BuildExactNavCommand());
            command.AddCommand(builder.BuildExpNavCommand());
            command.AddCommand(builder.BuildExpon_DistNavCommand());
            command.AddCommand(builder.BuildF_Dist_RTNavCommand());
            command.AddCommand(builder.BuildF_DistNavCommand());
            command.AddCommand(builder.BuildF_Inv_RTNavCommand());
            command.AddCommand(builder.BuildF_InvNavCommand());
            command.AddCommand(builder.BuildFactDoubleNavCommand());
            command.AddCommand(builder.BuildFactNavCommand());
            command.AddCommand(builder.BuildFalseNavCommand());
            command.AddCommand(builder.BuildFindBNavCommand());
            command.AddCommand(builder.BuildFindNavCommand());
            command.AddCommand(builder.BuildFisherInvNavCommand());
            command.AddCommand(builder.BuildFisherNavCommand());
            command.AddCommand(builder.BuildFixedNavCommand());
            command.AddCommand(builder.BuildFloor_MathNavCommand());
            command.AddCommand(builder.BuildFloor_PreciseNavCommand());
            command.AddCommand(builder.BuildFvNavCommand());
            command.AddCommand(builder.BuildFvscheduleNavCommand());
            command.AddCommand(builder.BuildGamma_DistNavCommand());
            command.AddCommand(builder.BuildGamma_InvNavCommand());
            command.AddCommand(builder.BuildGammaLn_PreciseNavCommand());
            command.AddCommand(builder.BuildGammaLnNavCommand());
            command.AddCommand(builder.BuildGammaNavCommand());
            command.AddCommand(builder.BuildGaussNavCommand());
            command.AddCommand(builder.BuildGcdNavCommand());
            command.AddCommand(builder.BuildGeoMeanNavCommand());
            command.AddCommand(builder.BuildGeStepNavCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildHarMeanNavCommand());
            command.AddCommand(builder.BuildHex2BinNavCommand());
            command.AddCommand(builder.BuildHex2DecNavCommand());
            command.AddCommand(builder.BuildHex2OctNavCommand());
            command.AddCommand(builder.BuildHlookupNavCommand());
            command.AddCommand(builder.BuildHourNavCommand());
            command.AddCommand(builder.BuildHyperlinkNavCommand());
            command.AddCommand(builder.BuildHypGeom_DistNavCommand());
            command.AddCommand(builder.BuildIfNavCommand());
            command.AddCommand(builder.BuildImAbsNavCommand());
            command.AddCommand(builder.BuildImaginaryNavCommand());
            command.AddCommand(builder.BuildImArgumentNavCommand());
            command.AddCommand(builder.BuildImConjugateNavCommand());
            command.AddCommand(builder.BuildImCoshNavCommand());
            command.AddCommand(builder.BuildImCosNavCommand());
            command.AddCommand(builder.BuildImCotNavCommand());
            command.AddCommand(builder.BuildImCschNavCommand());
            command.AddCommand(builder.BuildImCscNavCommand());
            command.AddCommand(builder.BuildImDivNavCommand());
            command.AddCommand(builder.BuildImExpNavCommand());
            command.AddCommand(builder.BuildImLnNavCommand());
            command.AddCommand(builder.BuildImLog10NavCommand());
            command.AddCommand(builder.BuildImLog2NavCommand());
            command.AddCommand(builder.BuildImPowerNavCommand());
            command.AddCommand(builder.BuildImProductNavCommand());
            command.AddCommand(builder.BuildImRealNavCommand());
            command.AddCommand(builder.BuildImSechNavCommand());
            command.AddCommand(builder.BuildImSecNavCommand());
            command.AddCommand(builder.BuildImSinhNavCommand());
            command.AddCommand(builder.BuildImSinNavCommand());
            command.AddCommand(builder.BuildImSqrtNavCommand());
            command.AddCommand(builder.BuildImSubNavCommand());
            command.AddCommand(builder.BuildImSumNavCommand());
            command.AddCommand(builder.BuildImTanNavCommand());
            command.AddCommand(builder.BuildIntNavCommand());
            command.AddCommand(builder.BuildIntRateNavCommand());
            command.AddCommand(builder.BuildIpmtNavCommand());
            command.AddCommand(builder.BuildIrrNavCommand());
            command.AddCommand(builder.BuildIsErrNavCommand());
            command.AddCommand(builder.BuildIsErrorNavCommand());
            command.AddCommand(builder.BuildIsEvenNavCommand());
            command.AddCommand(builder.BuildIsFormulaNavCommand());
            command.AddCommand(builder.BuildIsLogicalNavCommand());
            command.AddCommand(builder.BuildIsNANavCommand());
            command.AddCommand(builder.BuildIsNonTextNavCommand());
            command.AddCommand(builder.BuildIsNumberNavCommand());
            command.AddCommand(builder.BuildIso_CeilingNavCommand());
            command.AddCommand(builder.BuildIsOddNavCommand());
            command.AddCommand(builder.BuildIsoWeekNumNavCommand());
            command.AddCommand(builder.BuildIspmtNavCommand());
            command.AddCommand(builder.BuildIsrefNavCommand());
            command.AddCommand(builder.BuildIsTextNavCommand());
            command.AddCommand(builder.BuildKurtNavCommand());
            command.AddCommand(builder.BuildLargeNavCommand());
            command.AddCommand(builder.BuildLcmNavCommand());
            command.AddCommand(builder.BuildLeftbNavCommand());
            command.AddCommand(builder.BuildLeftNavCommand());
            command.AddCommand(builder.BuildLenbNavCommand());
            command.AddCommand(builder.BuildLenNavCommand());
            command.AddCommand(builder.BuildLnNavCommand());
            command.AddCommand(builder.BuildLog10NavCommand());
            command.AddCommand(builder.BuildLogNavCommand());
            command.AddCommand(builder.BuildLogNorm_DistNavCommand());
            command.AddCommand(builder.BuildLogNorm_InvNavCommand());
            command.AddCommand(builder.BuildLookupNavCommand());
            command.AddCommand(builder.BuildLowerNavCommand());
            command.AddCommand(builder.BuildMatchNavCommand());
            command.AddCommand(builder.BuildMaxANavCommand());
            command.AddCommand(builder.BuildMaxNavCommand());
            command.AddCommand(builder.BuildMdurationNavCommand());
            command.AddCommand(builder.BuildMedianNavCommand());
            command.AddCommand(builder.BuildMidbNavCommand());
            command.AddCommand(builder.BuildMidNavCommand());
            command.AddCommand(builder.BuildMinANavCommand());
            command.AddCommand(builder.BuildMinNavCommand());
            command.AddCommand(builder.BuildMinuteNavCommand());
            command.AddCommand(builder.BuildMirrNavCommand());
            command.AddCommand(builder.BuildModNavCommand());
            command.AddCommand(builder.BuildMonthNavCommand());
            command.AddCommand(builder.BuildMroundNavCommand());
            command.AddCommand(builder.BuildMultiNomialNavCommand());
            command.AddCommand(builder.BuildNaNavCommand());
            command.AddCommand(builder.BuildNegBinom_DistNavCommand());
            command.AddCommand(builder.BuildNetworkDays_IntlNavCommand());
            command.AddCommand(builder.BuildNetworkDaysNavCommand());
            command.AddCommand(builder.BuildNNavCommand());
            command.AddCommand(builder.BuildNominalNavCommand());
            command.AddCommand(builder.BuildNorm_DistNavCommand());
            command.AddCommand(builder.BuildNorm_InvNavCommand());
            command.AddCommand(builder.BuildNorm_S_DistNavCommand());
            command.AddCommand(builder.BuildNorm_S_InvNavCommand());
            command.AddCommand(builder.BuildNotNavCommand());
            command.AddCommand(builder.BuildNowNavCommand());
            command.AddCommand(builder.BuildNperNavCommand());
            command.AddCommand(builder.BuildNpvNavCommand());
            command.AddCommand(builder.BuildNumberValueNavCommand());
            command.AddCommand(builder.BuildOct2BinNavCommand());
            command.AddCommand(builder.BuildOct2DecNavCommand());
            command.AddCommand(builder.BuildOct2HexNavCommand());
            command.AddCommand(builder.BuildOddFPriceNavCommand());
            command.AddCommand(builder.BuildOddFYieldNavCommand());
            command.AddCommand(builder.BuildOddLPriceNavCommand());
            command.AddCommand(builder.BuildOddLYieldNavCommand());
            command.AddCommand(builder.BuildOddNavCommand());
            command.AddCommand(builder.BuildOrNavCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildPdurationNavCommand());
            command.AddCommand(builder.BuildPercentile_ExcNavCommand());
            command.AddCommand(builder.BuildPercentile_IncNavCommand());
            command.AddCommand(builder.BuildPercentRank_ExcNavCommand());
            command.AddCommand(builder.BuildPercentRank_IncNavCommand());
            command.AddCommand(builder.BuildPermutationaNavCommand());
            command.AddCommand(builder.BuildPermutNavCommand());
            command.AddCommand(builder.BuildPhiNavCommand());
            command.AddCommand(builder.BuildPiNavCommand());
            command.AddCommand(builder.BuildPmtNavCommand());
            command.AddCommand(builder.BuildPoisson_DistNavCommand());
            command.AddCommand(builder.BuildPowerNavCommand());
            command.AddCommand(builder.BuildPpmtNavCommand());
            command.AddCommand(builder.BuildPriceDiscNavCommand());
            command.AddCommand(builder.BuildPriceMatNavCommand());
            command.AddCommand(builder.BuildPriceNavCommand());
            command.AddCommand(builder.BuildProductNavCommand());
            command.AddCommand(builder.BuildProperNavCommand());
            command.AddCommand(builder.BuildPvNavCommand());
            command.AddCommand(builder.BuildQuartile_ExcNavCommand());
            command.AddCommand(builder.BuildQuartile_IncNavCommand());
            command.AddCommand(builder.BuildQuotientNavCommand());
            command.AddCommand(builder.BuildRadiansNavCommand());
            command.AddCommand(builder.BuildRandBetweenNavCommand());
            command.AddCommand(builder.BuildRandNavCommand());
            command.AddCommand(builder.BuildRank_AvgNavCommand());
            command.AddCommand(builder.BuildRank_EqNavCommand());
            command.AddCommand(builder.BuildRateNavCommand());
            command.AddCommand(builder.BuildReceivedNavCommand());
            command.AddCommand(builder.BuildReplaceBNavCommand());
            command.AddCommand(builder.BuildReplaceNavCommand());
            command.AddCommand(builder.BuildReptNavCommand());
            command.AddCommand(builder.BuildRightbNavCommand());
            command.AddCommand(builder.BuildRightNavCommand());
            command.AddCommand(builder.BuildRomanNavCommand());
            command.AddCommand(builder.BuildRoundDownNavCommand());
            command.AddCommand(builder.BuildRoundNavCommand());
            command.AddCommand(builder.BuildRoundUpNavCommand());
            command.AddCommand(builder.BuildRowsNavCommand());
            command.AddCommand(builder.BuildRriNavCommand());
            command.AddCommand(builder.BuildSechNavCommand());
            command.AddCommand(builder.BuildSecNavCommand());
            command.AddCommand(builder.BuildSecondNavCommand());
            command.AddCommand(builder.BuildSeriesSumNavCommand());
            command.AddCommand(builder.BuildSheetNavCommand());
            command.AddCommand(builder.BuildSheetsNavCommand());
            command.AddCommand(builder.BuildSignNavCommand());
            command.AddCommand(builder.BuildSinhNavCommand());
            command.AddCommand(builder.BuildSinNavCommand());
            command.AddCommand(builder.BuildSkew_pNavCommand());
            command.AddCommand(builder.BuildSkewNavCommand());
            command.AddCommand(builder.BuildSlnNavCommand());
            command.AddCommand(builder.BuildSmallNavCommand());
            command.AddCommand(builder.BuildSqrtNavCommand());
            command.AddCommand(builder.BuildSqrtPiNavCommand());
            command.AddCommand(builder.BuildStandardizeNavCommand());
            command.AddCommand(builder.BuildStDev_PNavCommand());
            command.AddCommand(builder.BuildStDev_SNavCommand());
            command.AddCommand(builder.BuildStDevANavCommand());
            command.AddCommand(builder.BuildStDevPANavCommand());
            command.AddCommand(builder.BuildSubstituteNavCommand());
            command.AddCommand(builder.BuildSubtotalNavCommand());
            command.AddCommand(builder.BuildSumIfNavCommand());
            command.AddCommand(builder.BuildSumIfsNavCommand());
            command.AddCommand(builder.BuildSumNavCommand());
            command.AddCommand(builder.BuildSumSqNavCommand());
            command.AddCommand(builder.BuildSydNavCommand());
            command.AddCommand(builder.BuildT_Dist_2TNavCommand());
            command.AddCommand(builder.BuildT_Dist_RTNavCommand());
            command.AddCommand(builder.BuildT_DistNavCommand());
            command.AddCommand(builder.BuildT_Inv_2TNavCommand());
            command.AddCommand(builder.BuildT_InvNavCommand());
            command.AddCommand(builder.BuildTanhNavCommand());
            command.AddCommand(builder.BuildTanNavCommand());
            command.AddCommand(builder.BuildTbillEqNavCommand());
            command.AddCommand(builder.BuildTbillPriceNavCommand());
            command.AddCommand(builder.BuildTbillYieldNavCommand());
            command.AddCommand(builder.BuildTextNavCommand());
            command.AddCommand(builder.BuildTimeNavCommand());
            command.AddCommand(builder.BuildTimevalueNavCommand());
            command.AddCommand(builder.BuildTNavCommand());
            command.AddCommand(builder.BuildTodayNavCommand());
            command.AddCommand(builder.BuildTrimMeanNavCommand());
            command.AddCommand(builder.BuildTrimNavCommand());
            command.AddCommand(builder.BuildTrueNavCommand());
            command.AddCommand(builder.BuildTruncNavCommand());
            command.AddCommand(builder.BuildTypeNavCommand());
            command.AddCommand(builder.BuildUnicharNavCommand());
            command.AddCommand(builder.BuildUnicodeNavCommand());
            command.AddCommand(builder.BuildUpperNavCommand());
            command.AddCommand(builder.BuildUsdollarNavCommand());
            command.AddCommand(builder.BuildValueNavCommand());
            command.AddCommand(builder.BuildVar_PNavCommand());
            command.AddCommand(builder.BuildVar_SNavCommand());
            command.AddCommand(builder.BuildVarANavCommand());
            command.AddCommand(builder.BuildVarPANavCommand());
            command.AddCommand(builder.BuildVdbNavCommand());
            command.AddCommand(builder.BuildVlookupNavCommand());
            command.AddCommand(builder.BuildWeekdayNavCommand());
            command.AddCommand(builder.BuildWeekNumNavCommand());
            command.AddCommand(builder.BuildWeibull_DistNavCommand());
            command.AddCommand(builder.BuildWorkDay_IntlNavCommand());
            command.AddCommand(builder.BuildWorkDayNavCommand());
            command.AddCommand(builder.BuildXirrNavCommand());
            command.AddCommand(builder.BuildXnpvNavCommand());
            command.AddCommand(builder.BuildXorNavCommand());
            command.AddCommand(builder.BuildYearFracNavCommand());
            command.AddCommand(builder.BuildYearNavCommand());
            command.AddCommand(builder.BuildYieldDiscNavCommand());
            command.AddCommand(builder.BuildYieldMatNavCommand());
            command.AddCommand(builder.BuildYieldNavCommand());
            command.AddCommand(builder.BuildZ_TestNavCommand());
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
        public Command BuildNamesNavCommand() {
            var command = new Command("names");
            command.Description = "Provides operations to manage the names property of the microsoft.graph.workbook entity.";
            var builder = new NamesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildAddFormulaLocalNavCommand());
            command.AddCommand(builder.BuildAddNavCommand());
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the operations property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildOperationsNavCommand() {
            var command = new Command("operations");
            command.Description = "Provides operations to manage the operations property of the microsoft.graph.workbook entity.";
            var builder = new OperationsRequestBuilder(PathParameters);
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
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
        public Command BuildRefreshSessionNavCommand() {
            var command = new Command("refresh-session");
            command.Description = "Provides operations to call the refreshSession method.";
            var builder = new RefreshSessionRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the tables property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildTablesNavCommand() {
            var command = new Command("tables");
            command.Description = "Provides operations to manage the tables property of the microsoft.graph.workbook entity.";
            var builder = new TablesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildAddNavCommand());
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the worksheets property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildWorksheetsNavCommand() {
            var command = new Command("worksheets");
            command.Description = "Provides operations to manage the worksheets property of the microsoft.graph.workbook entity.";
            var builder = new WorksheetsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildAddNavCommand());
            foreach (var cmd in builder.BuildCommand())
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(builder.BuildCountNavCommand());
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
