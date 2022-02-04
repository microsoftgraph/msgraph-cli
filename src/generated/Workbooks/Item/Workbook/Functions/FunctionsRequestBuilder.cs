using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Workbook.Functions.Abs;
using ApiSdk.Workbooks.Item.Workbook.Functions.AccrInt;
using ApiSdk.Workbooks.Item.Workbook.Functions.AccrIntM;
using ApiSdk.Workbooks.Item.Workbook.Functions.Acos;
using ApiSdk.Workbooks.Item.Workbook.Functions.Acosh;
using ApiSdk.Workbooks.Item.Workbook.Functions.Acot;
using ApiSdk.Workbooks.Item.Workbook.Functions.Acoth;
using ApiSdk.Workbooks.Item.Workbook.Functions.AmorDegrc;
using ApiSdk.Workbooks.Item.Workbook.Functions.AmorLinc;
using ApiSdk.Workbooks.Item.Workbook.Functions.And;
using ApiSdk.Workbooks.Item.Workbook.Functions.Arabic;
using ApiSdk.Workbooks.Item.Workbook.Functions.Areas;
using ApiSdk.Workbooks.Item.Workbook.Functions.Asc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Asin;
using ApiSdk.Workbooks.Item.Workbook.Functions.Asinh;
using ApiSdk.Workbooks.Item.Workbook.Functions.Atan;
using ApiSdk.Workbooks.Item.Workbook.Functions.Atan2;
using ApiSdk.Workbooks.Item.Workbook.Functions.Atanh;
using ApiSdk.Workbooks.Item.Workbook.Functions.AveDev;
using ApiSdk.Workbooks.Item.Workbook.Functions.Average;
using ApiSdk.Workbooks.Item.Workbook.Functions.AverageA;
using ApiSdk.Workbooks.Item.Workbook.Functions.AverageIf;
using ApiSdk.Workbooks.Item.Workbook.Functions.AverageIfs;
using ApiSdk.Workbooks.Item.Workbook.Functions.BahtText;
using ApiSdk.Workbooks.Item.Workbook.Functions.Base;
using ApiSdk.Workbooks.Item.Workbook.Functions.BesselI;
using ApiSdk.Workbooks.Item.Workbook.Functions.BesselJ;
using ApiSdk.Workbooks.Item.Workbook.Functions.BesselK;
using ApiSdk.Workbooks.Item.Workbook.Functions.BesselY;
using ApiSdk.Workbooks.Item.Workbook.Functions.Beta_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.Beta_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bin2Dec;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bin2Hex;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bin2Oct;
using ApiSdk.Workbooks.Item.Workbook.Functions.Binom_Dist_Range;
using ApiSdk.Workbooks.Item.Workbook.Functions.Binom_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.Binom_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bitand;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bitlshift;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bitor;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bitrshift;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bitxor;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ceiling_Math;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ceiling_Precise;
using ApiSdk.Workbooks.Item.Workbook.Functions.Char;
using ApiSdk.Workbooks.Item.Workbook.Functions.ChiSq_Dist_RT;
using ApiSdk.Workbooks.Item.Workbook.Functions.ChiSq_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.ChiSq_Inv_RT;
using ApiSdk.Workbooks.Item.Workbook.Functions.ChiSq_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Choose;
using ApiSdk.Workbooks.Item.Workbook.Functions.Clean;
using ApiSdk.Workbooks.Item.Workbook.Functions.Code;
using ApiSdk.Workbooks.Item.Workbook.Functions.Columns;
using ApiSdk.Workbooks.Item.Workbook.Functions.Combin;
using ApiSdk.Workbooks.Item.Workbook.Functions.Combina;
using ApiSdk.Workbooks.Item.Workbook.Functions.Complex;
using ApiSdk.Workbooks.Item.Workbook.Functions.Concatenate;
using ApiSdk.Workbooks.Item.Workbook.Functions.Confidence_Norm;
using ApiSdk.Workbooks.Item.Workbook.Functions.Confidence_T;
using ApiSdk.Workbooks.Item.Workbook.Functions.Convert;
using ApiSdk.Workbooks.Item.Workbook.Functions.Cos;
using ApiSdk.Workbooks.Item.Workbook.Functions.Cosh;
using ApiSdk.Workbooks.Item.Workbook.Functions.Cot;
using ApiSdk.Workbooks.Item.Workbook.Functions.Coth;
using ApiSdk.Workbooks.Item.Workbook.Functions.Count;
using ApiSdk.Workbooks.Item.Workbook.Functions.CountA;
using ApiSdk.Workbooks.Item.Workbook.Functions.CountBlank;
using ApiSdk.Workbooks.Item.Workbook.Functions.CountIf;
using ApiSdk.Workbooks.Item.Workbook.Functions.CountIfs;
using ApiSdk.Workbooks.Item.Workbook.Functions.CoupDayBs;
using ApiSdk.Workbooks.Item.Workbook.Functions.CoupDays;
using ApiSdk.Workbooks.Item.Workbook.Functions.CoupDaysNc;
using ApiSdk.Workbooks.Item.Workbook.Functions.CoupNcd;
using ApiSdk.Workbooks.Item.Workbook.Functions.CoupNum;
using ApiSdk.Workbooks.Item.Workbook.Functions.CoupPcd;
using ApiSdk.Workbooks.Item.Workbook.Functions.Csc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Csch;
using ApiSdk.Workbooks.Item.Workbook.Functions.CumIPmt;
using ApiSdk.Workbooks.Item.Workbook.Functions.CumPrinc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Date;
using ApiSdk.Workbooks.Item.Workbook.Functions.Datevalue;
using ApiSdk.Workbooks.Item.Workbook.Functions.Daverage;
using ApiSdk.Workbooks.Item.Workbook.Functions.Day;
using ApiSdk.Workbooks.Item.Workbook.Functions.Days;
using ApiSdk.Workbooks.Item.Workbook.Functions.Days360;
using ApiSdk.Workbooks.Item.Workbook.Functions.Db;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dbcs;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dcount;
using ApiSdk.Workbooks.Item.Workbook.Functions.DcountA;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ddb;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dec2Bin;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dec2Hex;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dec2Oct;
using ApiSdk.Workbooks.Item.Workbook.Functions.Decimal;
using ApiSdk.Workbooks.Item.Workbook.Functions.Degrees;
using ApiSdk.Workbooks.Item.Workbook.Functions.Delta;
using ApiSdk.Workbooks.Item.Workbook.Functions.DevSq;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dget;
using ApiSdk.Workbooks.Item.Workbook.Functions.Disc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dmax;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dmin;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dollar;
using ApiSdk.Workbooks.Item.Workbook.Functions.DollarDe;
using ApiSdk.Workbooks.Item.Workbook.Functions.DollarFr;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dproduct;
using ApiSdk.Workbooks.Item.Workbook.Functions.DstDev;
using ApiSdk.Workbooks.Item.Workbook.Functions.DstDevP;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dsum;
using ApiSdk.Workbooks.Item.Workbook.Functions.Duration;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dvar;
using ApiSdk.Workbooks.Item.Workbook.Functions.DvarP;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ecma_Ceiling;
using ApiSdk.Workbooks.Item.Workbook.Functions.Edate;
using ApiSdk.Workbooks.Item.Workbook.Functions.Effect;
using ApiSdk.Workbooks.Item.Workbook.Functions.EoMonth;
using ApiSdk.Workbooks.Item.Workbook.Functions.Erf_Precise;
using ApiSdk.Workbooks.Item.Workbook.Functions.Erf;
using ApiSdk.Workbooks.Item.Workbook.Functions.ErfC_Precise;
using ApiSdk.Workbooks.Item.Workbook.Functions.ErfC;
using ApiSdk.Workbooks.Item.Workbook.Functions.Error_Type;
using ApiSdk.Workbooks.Item.Workbook.Functions.Even;
using ApiSdk.Workbooks.Item.Workbook.Functions.Exact;
using ApiSdk.Workbooks.Item.Workbook.Functions.Exp;
using ApiSdk.Workbooks.Item.Workbook.Functions.Expon_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.F_Dist_RT;
using ApiSdk.Workbooks.Item.Workbook.Functions.F_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.F_Inv_RT;
using ApiSdk.Workbooks.Item.Workbook.Functions.F_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Fact;
using ApiSdk.Workbooks.Item.Workbook.Functions.FactDouble;
using ApiSdk.Workbooks.Item.Workbook.Functions.False;
using ApiSdk.Workbooks.Item.Workbook.Functions.Find;
using ApiSdk.Workbooks.Item.Workbook.Functions.FindB;
using ApiSdk.Workbooks.Item.Workbook.Functions.Fisher;
using ApiSdk.Workbooks.Item.Workbook.Functions.FisherInv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Fixed;
using ApiSdk.Workbooks.Item.Workbook.Functions.Floor_Math;
using ApiSdk.Workbooks.Item.Workbook.Functions.Floor_Precise;
using ApiSdk.Workbooks.Item.Workbook.Functions.Fv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Fvschedule;
using ApiSdk.Workbooks.Item.Workbook.Functions.Gamma_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.Gamma_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Gamma;
using ApiSdk.Workbooks.Item.Workbook.Functions.GammaLn_Precise;
using ApiSdk.Workbooks.Item.Workbook.Functions.GammaLn;
using ApiSdk.Workbooks.Item.Workbook.Functions.Gauss;
using ApiSdk.Workbooks.Item.Workbook.Functions.Gcd;
using ApiSdk.Workbooks.Item.Workbook.Functions.GeoMean;
using ApiSdk.Workbooks.Item.Workbook.Functions.GeStep;
using ApiSdk.Workbooks.Item.Workbook.Functions.HarMean;
using ApiSdk.Workbooks.Item.Workbook.Functions.Hex2Bin;
using ApiSdk.Workbooks.Item.Workbook.Functions.Hex2Dec;
using ApiSdk.Workbooks.Item.Workbook.Functions.Hex2Oct;
using ApiSdk.Workbooks.Item.Workbook.Functions.Hlookup;
using ApiSdk.Workbooks.Item.Workbook.Functions.Hour;
using ApiSdk.Workbooks.Item.Workbook.Functions.Hyperlink;
using ApiSdk.Workbooks.Item.Workbook.Functions.HypGeom_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.If;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImAbs;
using ApiSdk.Workbooks.Item.Workbook.Functions.Imaginary;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImArgument;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImConjugate;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImCos;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImCosh;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImCot;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImCsc;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImCsch;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImDiv;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImExp;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImLn;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImLog10;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImLog2;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImPower;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImProduct;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImReal;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImSec;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImSech;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImSin;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImSinh;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImSqrt;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImSub;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImSum;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImTan;
using ApiSdk.Workbooks.Item.Workbook.Functions.Int;
using ApiSdk.Workbooks.Item.Workbook.Functions.IntRate;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ipmt;
using ApiSdk.Workbooks.Item.Workbook.Functions.Irr;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsErr;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsError;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsEven;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsFormula;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsLogical;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsNA;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsNonText;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsNumber;
using ApiSdk.Workbooks.Item.Workbook.Functions.Iso_Ceiling;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsOdd;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsoWeekNum;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ispmt;
using ApiSdk.Workbooks.Item.Workbook.Functions.Isref;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsText;
using ApiSdk.Workbooks.Item.Workbook.Functions.Kurt;
using ApiSdk.Workbooks.Item.Workbook.Functions.Large;
using ApiSdk.Workbooks.Item.Workbook.Functions.Lcm;
using ApiSdk.Workbooks.Item.Workbook.Functions.Left;
using ApiSdk.Workbooks.Item.Workbook.Functions.Leftb;
using ApiSdk.Workbooks.Item.Workbook.Functions.Len;
using ApiSdk.Workbooks.Item.Workbook.Functions.Lenb;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ln;
using ApiSdk.Workbooks.Item.Workbook.Functions.Log;
using ApiSdk.Workbooks.Item.Workbook.Functions.Log10;
using ApiSdk.Workbooks.Item.Workbook.Functions.LogNorm_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.LogNorm_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Lookup;
using ApiSdk.Workbooks.Item.Workbook.Functions.Lower;
using ApiSdk.Workbooks.Item.Workbook.Functions.Match;
using ApiSdk.Workbooks.Item.Workbook.Functions.Max;
using ApiSdk.Workbooks.Item.Workbook.Functions.MaxA;
using ApiSdk.Workbooks.Item.Workbook.Functions.Mduration;
using ApiSdk.Workbooks.Item.Workbook.Functions.Median;
using ApiSdk.Workbooks.Item.Workbook.Functions.Mid;
using ApiSdk.Workbooks.Item.Workbook.Functions.Midb;
using ApiSdk.Workbooks.Item.Workbook.Functions.Min;
using ApiSdk.Workbooks.Item.Workbook.Functions.MinA;
using ApiSdk.Workbooks.Item.Workbook.Functions.Minute;
using ApiSdk.Workbooks.Item.Workbook.Functions.Mirr;
using ApiSdk.Workbooks.Item.Workbook.Functions.Mod;
using ApiSdk.Workbooks.Item.Workbook.Functions.Month;
using ApiSdk.Workbooks.Item.Workbook.Functions.Mround;
using ApiSdk.Workbooks.Item.Workbook.Functions.MultiNomial;
using ApiSdk.Workbooks.Item.Workbook.Functions.N;
using ApiSdk.Workbooks.Item.Workbook.Functions.Na;
using ApiSdk.Workbooks.Item.Workbook.Functions.NegBinom_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.NetworkDays_Intl;
using ApiSdk.Workbooks.Item.Workbook.Functions.NetworkDays;
using ApiSdk.Workbooks.Item.Workbook.Functions.Nominal;
using ApiSdk.Workbooks.Item.Workbook.Functions.Norm_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.Norm_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Norm_S_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.Norm_S_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Not;
using ApiSdk.Workbooks.Item.Workbook.Functions.Now;
using ApiSdk.Workbooks.Item.Workbook.Functions.Nper;
using ApiSdk.Workbooks.Item.Workbook.Functions.Npv;
using ApiSdk.Workbooks.Item.Workbook.Functions.NumberValue;
using ApiSdk.Workbooks.Item.Workbook.Functions.Oct2Bin;
using ApiSdk.Workbooks.Item.Workbook.Functions.Oct2Dec;
using ApiSdk.Workbooks.Item.Workbook.Functions.Oct2Hex;
using ApiSdk.Workbooks.Item.Workbook.Functions.Odd;
using ApiSdk.Workbooks.Item.Workbook.Functions.OddFPrice;
using ApiSdk.Workbooks.Item.Workbook.Functions.OddFYield;
using ApiSdk.Workbooks.Item.Workbook.Functions.OddLPrice;
using ApiSdk.Workbooks.Item.Workbook.Functions.OddLYield;
using ApiSdk.Workbooks.Item.Workbook.Functions.Or;
using ApiSdk.Workbooks.Item.Workbook.Functions.Pduration;
using ApiSdk.Workbooks.Item.Workbook.Functions.Percentile_Exc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Percentile_Inc;
using ApiSdk.Workbooks.Item.Workbook.Functions.PercentRank_Exc;
using ApiSdk.Workbooks.Item.Workbook.Functions.PercentRank_Inc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Permut;
using ApiSdk.Workbooks.Item.Workbook.Functions.Permutationa;
using ApiSdk.Workbooks.Item.Workbook.Functions.Phi;
using ApiSdk.Workbooks.Item.Workbook.Functions.Pi;
using ApiSdk.Workbooks.Item.Workbook.Functions.Pmt;
using ApiSdk.Workbooks.Item.Workbook.Functions.Poisson_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.Power;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ppmt;
using ApiSdk.Workbooks.Item.Workbook.Functions.Price;
using ApiSdk.Workbooks.Item.Workbook.Functions.PriceDisc;
using ApiSdk.Workbooks.Item.Workbook.Functions.PriceMat;
using ApiSdk.Workbooks.Item.Workbook.Functions.Product;
using ApiSdk.Workbooks.Item.Workbook.Functions.Proper;
using ApiSdk.Workbooks.Item.Workbook.Functions.Pv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Quartile_Exc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Quartile_Inc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Quotient;
using ApiSdk.Workbooks.Item.Workbook.Functions.Radians;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rand;
using ApiSdk.Workbooks.Item.Workbook.Functions.RandBetween;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rank_Avg;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rank_Eq;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rate;
using ApiSdk.Workbooks.Item.Workbook.Functions.Received;
using ApiSdk.Workbooks.Item.Workbook.Functions.Replace;
using ApiSdk.Workbooks.Item.Workbook.Functions.ReplaceB;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rept;
using ApiSdk.Workbooks.Item.Workbook.Functions.Right;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rightb;
using ApiSdk.Workbooks.Item.Workbook.Functions.Roman;
using ApiSdk.Workbooks.Item.Workbook.Functions.Round;
using ApiSdk.Workbooks.Item.Workbook.Functions.RoundDown;
using ApiSdk.Workbooks.Item.Workbook.Functions.RoundUp;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rows;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rri;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sec;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sech;
using ApiSdk.Workbooks.Item.Workbook.Functions.Second;
using ApiSdk.Workbooks.Item.Workbook.Functions.SeriesSum;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sheet;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sheets;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sign;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sin;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sinh;
using ApiSdk.Workbooks.Item.Workbook.Functions.Skew_p;
using ApiSdk.Workbooks.Item.Workbook.Functions.Skew;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sln;
using ApiSdk.Workbooks.Item.Workbook.Functions.Small;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sqrt;
using ApiSdk.Workbooks.Item.Workbook.Functions.SqrtPi;
using ApiSdk.Workbooks.Item.Workbook.Functions.Standardize;
using ApiSdk.Workbooks.Item.Workbook.Functions.StDev_P;
using ApiSdk.Workbooks.Item.Workbook.Functions.StDev_S;
using ApiSdk.Workbooks.Item.Workbook.Functions.StDevA;
using ApiSdk.Workbooks.Item.Workbook.Functions.StDevPA;
using ApiSdk.Workbooks.Item.Workbook.Functions.Substitute;
using ApiSdk.Workbooks.Item.Workbook.Functions.Subtotal;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sum;
using ApiSdk.Workbooks.Item.Workbook.Functions.SumIf;
using ApiSdk.Workbooks.Item.Workbook.Functions.SumIfs;
using ApiSdk.Workbooks.Item.Workbook.Functions.SumSq;
using ApiSdk.Workbooks.Item.Workbook.Functions.Syd;
using ApiSdk.Workbooks.Item.Workbook.Functions.T_Dist_2T;
using ApiSdk.Workbooks.Item.Workbook.Functions.T_Dist_RT;
using ApiSdk.Workbooks.Item.Workbook.Functions.T_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.T_Inv_2T;
using ApiSdk.Workbooks.Item.Workbook.Functions.T_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.T;
using ApiSdk.Workbooks.Item.Workbook.Functions.Tan;
using ApiSdk.Workbooks.Item.Workbook.Functions.Tanh;
using ApiSdk.Workbooks.Item.Workbook.Functions.TbillEq;
using ApiSdk.Workbooks.Item.Workbook.Functions.TbillPrice;
using ApiSdk.Workbooks.Item.Workbook.Functions.TbillYield;
using ApiSdk.Workbooks.Item.Workbook.Functions.Text;
using ApiSdk.Workbooks.Item.Workbook.Functions.Time;
using ApiSdk.Workbooks.Item.Workbook.Functions.Timevalue;
using ApiSdk.Workbooks.Item.Workbook.Functions.Today;
using ApiSdk.Workbooks.Item.Workbook.Functions.Trim;
using ApiSdk.Workbooks.Item.Workbook.Functions.TrimMean;
using ApiSdk.Workbooks.Item.Workbook.Functions.True;
using ApiSdk.Workbooks.Item.Workbook.Functions.Trunc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Type;
using ApiSdk.Workbooks.Item.Workbook.Functions.Unichar;
using ApiSdk.Workbooks.Item.Workbook.Functions.Unicode;
using ApiSdk.Workbooks.Item.Workbook.Functions.Upper;
using ApiSdk.Workbooks.Item.Workbook.Functions.Usdollar;
using ApiSdk.Workbooks.Item.Workbook.Functions.Value;
using ApiSdk.Workbooks.Item.Workbook.Functions.Var_P;
using ApiSdk.Workbooks.Item.Workbook.Functions.Var_S;
using ApiSdk.Workbooks.Item.Workbook.Functions.VarA;
using ApiSdk.Workbooks.Item.Workbook.Functions.VarPA;
using ApiSdk.Workbooks.Item.Workbook.Functions.Vdb;
using ApiSdk.Workbooks.Item.Workbook.Functions.Vlookup;
using ApiSdk.Workbooks.Item.Workbook.Functions.Weekday;
using ApiSdk.Workbooks.Item.Workbook.Functions.WeekNum;
using ApiSdk.Workbooks.Item.Workbook.Functions.Weibull_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.WorkDay_Intl;
using ApiSdk.Workbooks.Item.Workbook.Functions.WorkDay;
using ApiSdk.Workbooks.Item.Workbook.Functions.Xirr;
using ApiSdk.Workbooks.Item.Workbook.Functions.Xnpv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Xor;
using ApiSdk.Workbooks.Item.Workbook.Functions.Year;
using ApiSdk.Workbooks.Item.Workbook.Functions.YearFrac;
using ApiSdk.Workbooks.Item.Workbook.Functions.Yield;
using ApiSdk.Workbooks.Item.Workbook.Functions.YieldDisc;
using ApiSdk.Workbooks.Item.Workbook.Functions.YieldMat;
using ApiSdk.Workbooks.Item.Workbook.Functions.Z_Test;
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
namespace ApiSdk.Workbooks.Item.Workbook.Functions {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\functions</summary>
    public class FunctionsRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAbsCommand() {
            var command = new Command("abs");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Abs.AbsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAccrIntCommand() {
            var command = new Command("accr-int");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.AccrInt.AccrIntRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAccrIntMCommand() {
            var command = new Command("accr-int-m");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.AccrIntM.AccrIntMRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAcosCommand() {
            var command = new Command("acos");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Acos.AcosRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAcoshCommand() {
            var command = new Command("acosh");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Acosh.AcoshRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAcotCommand() {
            var command = new Command("acot");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Acot.AcotRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAcothCommand() {
            var command = new Command("acoth");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Acoth.AcothRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAmorDegrcCommand() {
            var command = new Command("amor-degrc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.AmorDegrc.AmorDegrcRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAmorLincCommand() {
            var command = new Command("amor-linc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.AmorLinc.AmorLincRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAndCommand() {
            var command = new Command("and");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.And.AndRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildArabicCommand() {
            var command = new Command("arabic");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Arabic.ArabicRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAreasCommand() {
            var command = new Command("areas");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Areas.AreasRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAscCommand() {
            var command = new Command("asc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Asc.AscRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAsinCommand() {
            var command = new Command("asin");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Asin.AsinRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAsinhCommand() {
            var command = new Command("asinh");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Asinh.AsinhRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAtan2Command() {
            var command = new Command("atan2");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Atan2.Atan2RequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAtanCommand() {
            var command = new Command("atan");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Atan.AtanRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAtanhCommand() {
            var command = new Command("atanh");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Atanh.AtanhRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAveDevCommand() {
            var command = new Command("ave-dev");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.AveDev.AveDevRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAverageACommand() {
            var command = new Command("average-a");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.AverageA.AverageARequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAverageCommand() {
            var command = new Command("average");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Average.AverageRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAverageIfCommand() {
            var command = new Command("average-if");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.AverageIf.AverageIfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildAverageIfsCommand() {
            var command = new Command("average-ifs");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.AverageIfs.AverageIfsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBahtTextCommand() {
            var command = new Command("baht-text");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.BahtText.BahtTextRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBaseCommand() {
            var command = new Command("base");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Base.BaseRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBesselICommand() {
            var command = new Command("bessel-i");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.BesselI.BesselIRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBesselJCommand() {
            var command = new Command("bessel-j");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.BesselJ.BesselJRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBesselKCommand() {
            var command = new Command("bessel-k");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.BesselK.BesselKRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBesselYCommand() {
            var command = new Command("bessel-y");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.BesselY.BesselYRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBeta_DistCommand() {
            var command = new Command("beta_-dist");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Beta_Dist.Beta_DistRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBeta_InvCommand() {
            var command = new Command("beta_-inv");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Beta_Inv.Beta_InvRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBin2DecCommand() {
            var command = new Command("bin2-dec");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Bin2Dec.Bin2DecRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBin2HexCommand() {
            var command = new Command("bin2-hex");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Bin2Hex.Bin2HexRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBin2OctCommand() {
            var command = new Command("bin2-oct");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Bin2Oct.Bin2OctRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBinom_Dist_RangeCommand() {
            var command = new Command("binom_-dist_-range");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Binom_Dist_Range.Binom_Dist_RangeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBinom_DistCommand() {
            var command = new Command("binom_-dist");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Binom_Dist.Binom_DistRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBinom_InvCommand() {
            var command = new Command("binom_-inv");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Binom_Inv.Binom_InvRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBitandCommand() {
            var command = new Command("bitand");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Bitand.BitandRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBitlshiftCommand() {
            var command = new Command("bitlshift");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Bitlshift.BitlshiftRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBitorCommand() {
            var command = new Command("bitor");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Bitor.BitorRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBitrshiftCommand() {
            var command = new Command("bitrshift");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Bitrshift.BitrshiftRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildBitxorCommand() {
            var command = new Command("bitxor");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Bitxor.BitxorRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCeiling_MathCommand() {
            var command = new Command("ceiling_-math");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Ceiling_Math.Ceiling_MathRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCeiling_PreciseCommand() {
            var command = new Command("ceiling_-precise");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Ceiling_Precise.Ceiling_PreciseRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCharCommand() {
            var command = new Command("char");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Char.CharRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildChiSq_Dist_RTCommand() {
            var command = new Command("chi-sq_-dist_-r-t");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ChiSq_Dist_RT.ChiSq_Dist_RTRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildChiSq_DistCommand() {
            var command = new Command("chi-sq_-dist");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ChiSq_Dist.ChiSq_DistRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildChiSq_Inv_RTCommand() {
            var command = new Command("chi-sq_-inv_-r-t");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ChiSq_Inv_RT.ChiSq_Inv_RTRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildChiSq_InvCommand() {
            var command = new Command("chi-sq_-inv");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ChiSq_Inv.ChiSq_InvRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildChooseCommand() {
            var command = new Command("choose");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Choose.ChooseRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCleanCommand() {
            var command = new Command("clean");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Clean.CleanRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCodeCommand() {
            var command = new Command("code");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Code.CodeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildColumnsCommand() {
            var command = new Command("columns");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Columns.ColumnsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCombinaCommand() {
            var command = new Command("combina");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Combina.CombinaRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCombinCommand() {
            var command = new Command("combin");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Combin.CombinRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildComplexCommand() {
            var command = new Command("complex");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Complex.ComplexRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildConcatenateCommand() {
            var command = new Command("concatenate");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Concatenate.ConcatenateRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildConfidence_NormCommand() {
            var command = new Command("confidence_-norm");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Confidence_Norm.Confidence_NormRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildConfidence_TCommand() {
            var command = new Command("confidence_-t");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Confidence_T.Confidence_TRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildConvertCommand() {
            var command = new Command("convert");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Convert.ConvertRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCosCommand() {
            var command = new Command("cos");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Cos.CosRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCoshCommand() {
            var command = new Command("cosh");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Cosh.CoshRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCotCommand() {
            var command = new Command("cot");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Cot.CotRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCothCommand() {
            var command = new Command("coth");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Coth.CothRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCountACommand() {
            var command = new Command("count-a");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.CountA.CountARequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCountBlankCommand() {
            var command = new Command("count-blank");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.CountBlank.CountBlankRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCountCommand() {
            var command = new Command("count");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Count.CountRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCountIfCommand() {
            var command = new Command("count-if");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.CountIf.CountIfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCountIfsCommand() {
            var command = new Command("count-ifs");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.CountIfs.CountIfsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCoupDayBsCommand() {
            var command = new Command("coup-day-bs");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.CoupDayBs.CoupDayBsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCoupDaysCommand() {
            var command = new Command("coup-days");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.CoupDays.CoupDaysRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCoupDaysNcCommand() {
            var command = new Command("coup-days-nc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.CoupDaysNc.CoupDaysNcRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCoupNcdCommand() {
            var command = new Command("coup-ncd");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.CoupNcd.CoupNcdRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCoupNumCommand() {
            var command = new Command("coup-num");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.CoupNum.CoupNumRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCoupPcdCommand() {
            var command = new Command("coup-pcd");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.CoupPcd.CoupPcdRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCscCommand() {
            var command = new Command("csc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Csc.CscRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCschCommand() {
            var command = new Command("csch");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Csch.CschRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCumIPmtCommand() {
            var command = new Command("cum-i-pmt");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.CumIPmt.CumIPmtRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCumPrincCommand() {
            var command = new Command("cum-princ");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.CumPrinc.CumPrincRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDateCommand() {
            var command = new Command("date");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Date.DateRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDatevalueCommand() {
            var command = new Command("datevalue");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Datevalue.DatevalueRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDaverageCommand() {
            var command = new Command("daverage");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Daverage.DaverageRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDayCommand() {
            var command = new Command("day");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Day.DayRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDays360Command() {
            var command = new Command("days360");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Days360.Days360RequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDaysCommand() {
            var command = new Command("days");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Days.DaysRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDbCommand() {
            var command = new Command("db");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Db.DbRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDbcsCommand() {
            var command = new Command("dbcs");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Dbcs.DbcsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDcountACommand() {
            var command = new Command("dcount-a");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.DcountA.DcountARequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDcountCommand() {
            var command = new Command("dcount");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Dcount.DcountRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDdbCommand() {
            var command = new Command("ddb");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Ddb.DdbRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDec2BinCommand() {
            var command = new Command("dec2-bin");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Dec2Bin.Dec2BinRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDec2HexCommand() {
            var command = new Command("dec2-hex");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Dec2Hex.Dec2HexRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDec2OctCommand() {
            var command = new Command("dec2-oct");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Dec2Oct.Dec2OctRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDecimalCommand() {
            var command = new Command("decimal");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Decimal.DecimalRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDegreesCommand() {
            var command = new Command("degrees");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Degrees.DegreesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Delete navigation property functions for workbooks
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property functions for workbooks";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--driveitem-id", description: "key: id of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            command.SetHandler(async (string driveItemId, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo);
                console.WriteLine("Success");
            }, driveItemIdOption);
            return command;
        }
        public Command BuildDeltaCommand() {
            var command = new Command("delta");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Delta.DeltaRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDevSqCommand() {
            var command = new Command("dev-sq");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.DevSq.DevSqRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDgetCommand() {
            var command = new Command("dget");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Dget.DgetRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDiscCommand() {
            var command = new Command("disc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Disc.DiscRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDmaxCommand() {
            var command = new Command("dmax");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Dmax.DmaxRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDminCommand() {
            var command = new Command("dmin");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Dmin.DminRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDollarCommand() {
            var command = new Command("dollar");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Dollar.DollarRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDollarDeCommand() {
            var command = new Command("dollar-de");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.DollarDe.DollarDeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDollarFrCommand() {
            var command = new Command("dollar-fr");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.DollarFr.DollarFrRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDproductCommand() {
            var command = new Command("dproduct");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Dproduct.DproductRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDstDevCommand() {
            var command = new Command("dst-dev");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.DstDev.DstDevRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDstDevPCommand() {
            var command = new Command("dst-dev-p");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.DstDevP.DstDevPRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDsumCommand() {
            var command = new Command("dsum");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Dsum.DsumRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDurationCommand() {
            var command = new Command("duration");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Duration.DurationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDvarCommand() {
            var command = new Command("dvar");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Dvar.DvarRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildDvarPCommand() {
            var command = new Command("dvar-p");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.DvarP.DvarPRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildEcma_CeilingCommand() {
            var command = new Command("ecma_-ceiling");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Ecma_Ceiling.Ecma_CeilingRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildEdateCommand() {
            var command = new Command("edate");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Edate.EdateRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildEffectCommand() {
            var command = new Command("effect");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Effect.EffectRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildEoMonthCommand() {
            var command = new Command("eo-month");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.EoMonth.EoMonthRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildErf_PreciseCommand() {
            var command = new Command("erf_-precise");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Erf_Precise.Erf_PreciseRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildErfC_PreciseCommand() {
            var command = new Command("erf-c_-precise");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ErfC_Precise.ErfC_PreciseRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildErfCCommand() {
            var command = new Command("erf-c");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ErfC.ErfCRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildErfCommand() {
            var command = new Command("erf");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Erf.ErfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildError_TypeCommand() {
            var command = new Command("error_-type");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Error_Type.Error_TypeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildEvenCommand() {
            var command = new Command("even");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Even.EvenRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildExactCommand() {
            var command = new Command("exact");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Exact.ExactRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildExpCommand() {
            var command = new Command("exp");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Exp.ExpRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildExpon_DistCommand() {
            var command = new Command("expon_-dist");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Expon_Dist.Expon_DistRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildF_Dist_RTCommand() {
            var command = new Command("f_-dist_-r-t");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.F_Dist_RT.F_Dist_RTRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildF_DistCommand() {
            var command = new Command("f_-dist");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.F_Dist.F_DistRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildF_Inv_RTCommand() {
            var command = new Command("f_-inv_-r-t");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.F_Inv_RT.F_Inv_RTRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildF_InvCommand() {
            var command = new Command("f_-inv");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.F_Inv.F_InvRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildFactCommand() {
            var command = new Command("fact");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Fact.FactRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildFactDoubleCommand() {
            var command = new Command("fact-double");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.FactDouble.FactDoubleRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildFalseCommand() {
            var command = new Command("false");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.False.FalseRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildFindBCommand() {
            var command = new Command("find-b");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.FindB.FindBRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildFindCommand() {
            var command = new Command("find");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Find.FindRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildFisherCommand() {
            var command = new Command("fisher");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Fisher.FisherRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildFisherInvCommand() {
            var command = new Command("fisher-inv");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.FisherInv.FisherInvRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildFixedCommand() {
            var command = new Command("fixed");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Fixed.FixedRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildFloor_MathCommand() {
            var command = new Command("floor_-math");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Floor_Math.Floor_MathRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildFloor_PreciseCommand() {
            var command = new Command("floor_-precise");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Floor_Precise.Floor_PreciseRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildFvCommand() {
            var command = new Command("fv");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Fv.FvRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildFvscheduleCommand() {
            var command = new Command("fvschedule");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Fvschedule.FvscheduleRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGamma_DistCommand() {
            var command = new Command("gamma_-dist");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Gamma_Dist.Gamma_DistRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGamma_InvCommand() {
            var command = new Command("gamma_-inv");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Gamma_Inv.Gamma_InvRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGammaCommand() {
            var command = new Command("gamma");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Gamma.GammaRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGammaLn_PreciseCommand() {
            var command = new Command("gamma-ln_-precise");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.GammaLn_Precise.GammaLn_PreciseRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGammaLnCommand() {
            var command = new Command("gamma-ln");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.GammaLn.GammaLnRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGaussCommand() {
            var command = new Command("gauss");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Gauss.GaussRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGcdCommand() {
            var command = new Command("gcd");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Gcd.GcdRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGeoMeanCommand() {
            var command = new Command("geo-mean");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.GeoMean.GeoMeanRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGeStepCommand() {
            var command = new Command("ge-step");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.GeStep.GeStepRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Get functions from workbooks
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get functions from workbooks";
            // Create options for all the parameters
            var driveItemIdOption = new Option<string>("--driveitem-id", description: "key: id of driveItem") {
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
            command.SetHandler(async (string driveItemId, string[] select, string[] expand, FormatterType output, IOutputFormatterFactory outputFormatterFactory, IConsole console) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo);
                var formatter = outputFormatterFactory.GetFormatter(output);
                formatter.WriteOutput(response, console);
            }, driveItemIdOption, selectOption, expandOption, outputOption);
            return command;
        }
        public Command BuildHarMeanCommand() {
            var command = new Command("har-mean");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.HarMean.HarMeanRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildHex2BinCommand() {
            var command = new Command("hex2-bin");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Hex2Bin.Hex2BinRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildHex2DecCommand() {
            var command = new Command("hex2-dec");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Hex2Dec.Hex2DecRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildHex2OctCommand() {
            var command = new Command("hex2-oct");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Hex2Oct.Hex2OctRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildHlookupCommand() {
            var command = new Command("hlookup");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Hlookup.HlookupRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildHourCommand() {
            var command = new Command("hour");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Hour.HourRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildHyperlinkCommand() {
            var command = new Command("hyperlink");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Hyperlink.HyperlinkRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildHypGeom_DistCommand() {
            var command = new Command("hyp-geom_-dist");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.HypGeom_Dist.HypGeom_DistRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIfCommand() {
            var command = new Command("if");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.If.IfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImAbsCommand() {
            var command = new Command("im-abs");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImAbs.ImAbsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImaginaryCommand() {
            var command = new Command("imaginary");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Imaginary.ImaginaryRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImArgumentCommand() {
            var command = new Command("im-argument");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImArgument.ImArgumentRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImConjugateCommand() {
            var command = new Command("im-conjugate");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImConjugate.ImConjugateRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImCosCommand() {
            var command = new Command("im-cos");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImCos.ImCosRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImCoshCommand() {
            var command = new Command("im-cosh");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImCosh.ImCoshRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImCotCommand() {
            var command = new Command("im-cot");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImCot.ImCotRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImCscCommand() {
            var command = new Command("im-csc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImCsc.ImCscRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImCschCommand() {
            var command = new Command("im-csch");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImCsch.ImCschRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImDivCommand() {
            var command = new Command("im-div");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImDiv.ImDivRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImExpCommand() {
            var command = new Command("im-exp");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImExp.ImExpRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImLnCommand() {
            var command = new Command("im-ln");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImLn.ImLnRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImLog10Command() {
            var command = new Command("im-log10");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImLog10.ImLog10RequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImLog2Command() {
            var command = new Command("im-log2");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImLog2.ImLog2RequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImPowerCommand() {
            var command = new Command("im-power");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImPower.ImPowerRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImProductCommand() {
            var command = new Command("im-product");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImProduct.ImProductRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImRealCommand() {
            var command = new Command("im-real");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImReal.ImRealRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImSecCommand() {
            var command = new Command("im-sec");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImSec.ImSecRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImSechCommand() {
            var command = new Command("im-sech");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImSech.ImSechRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImSinCommand() {
            var command = new Command("im-sin");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImSin.ImSinRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImSinhCommand() {
            var command = new Command("im-sinh");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImSinh.ImSinhRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImSqrtCommand() {
            var command = new Command("im-sqrt");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImSqrt.ImSqrtRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImSubCommand() {
            var command = new Command("im-sub");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImSub.ImSubRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImSumCommand() {
            var command = new Command("im-sum");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImSum.ImSumRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildImTanCommand() {
            var command = new Command("im-tan");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ImTan.ImTanRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIntCommand() {
            var command = new Command("int");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Int.IntRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIntRateCommand() {
            var command = new Command("int-rate");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.IntRate.IntRateRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIpmtCommand() {
            var command = new Command("ipmt");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Ipmt.IpmtRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIrrCommand() {
            var command = new Command("irr");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Irr.IrrRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIsErrCommand() {
            var command = new Command("is-err");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.IsErr.IsErrRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIsErrorCommand() {
            var command = new Command("is-error");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.IsError.IsErrorRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIsEvenCommand() {
            var command = new Command("is-even");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.IsEven.IsEvenRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIsFormulaCommand() {
            var command = new Command("is-formula");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.IsFormula.IsFormulaRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIsLogicalCommand() {
            var command = new Command("is-logical");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.IsLogical.IsLogicalRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIsNACommand() {
            var command = new Command("is-n-a");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.IsNA.IsNARequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIsNonTextCommand() {
            var command = new Command("is-non-text");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.IsNonText.IsNonTextRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIsNumberCommand() {
            var command = new Command("is-number");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.IsNumber.IsNumberRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIso_CeilingCommand() {
            var command = new Command("iso_-ceiling");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Iso_Ceiling.Iso_CeilingRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIsOddCommand() {
            var command = new Command("is-odd");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.IsOdd.IsOddRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIsoWeekNumCommand() {
            var command = new Command("iso-week-num");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.IsoWeekNum.IsoWeekNumRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIspmtCommand() {
            var command = new Command("ispmt");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Ispmt.IspmtRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIsrefCommand() {
            var command = new Command("isref");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Isref.IsrefRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildIsTextCommand() {
            var command = new Command("is-text");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.IsText.IsTextRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildKurtCommand() {
            var command = new Command("kurt");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Kurt.KurtRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildLargeCommand() {
            var command = new Command("large");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Large.LargeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildLcmCommand() {
            var command = new Command("lcm");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Lcm.LcmRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildLeftbCommand() {
            var command = new Command("leftb");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Leftb.LeftbRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildLeftCommand() {
            var command = new Command("left");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Left.LeftRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildLenbCommand() {
            var command = new Command("lenb");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Lenb.LenbRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildLenCommand() {
            var command = new Command("len");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Len.LenRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildLnCommand() {
            var command = new Command("ln");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Ln.LnRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildLog10Command() {
            var command = new Command("log10");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Log10.Log10RequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildLogCommand() {
            var command = new Command("log");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Log.LogRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildLogNorm_DistCommand() {
            var command = new Command("log-norm_-dist");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.LogNorm_Dist.LogNorm_DistRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildLogNorm_InvCommand() {
            var command = new Command("log-norm_-inv");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.LogNorm_Inv.LogNorm_InvRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildLookupCommand() {
            var command = new Command("lookup");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Lookup.LookupRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildLowerCommand() {
            var command = new Command("lower");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Lower.LowerRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMatchCommand() {
            var command = new Command("match");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Match.MatchRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMaxACommand() {
            var command = new Command("max-a");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.MaxA.MaxARequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMaxCommand() {
            var command = new Command("max");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Max.MaxRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMdurationCommand() {
            var command = new Command("mduration");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Mduration.MdurationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMedianCommand() {
            var command = new Command("median");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Median.MedianRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMidbCommand() {
            var command = new Command("midb");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Midb.MidbRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMidCommand() {
            var command = new Command("mid");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Mid.MidRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMinACommand() {
            var command = new Command("min-a");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.MinA.MinARequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMinCommand() {
            var command = new Command("min");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Min.MinRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMinuteCommand() {
            var command = new Command("minute");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Minute.MinuteRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMirrCommand() {
            var command = new Command("mirr");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Mirr.MirrRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildModCommand() {
            var command = new Command("mod");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Mod.ModRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMonthCommand() {
            var command = new Command("month");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Month.MonthRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMroundCommand() {
            var command = new Command("mround");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Mround.MroundRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildMultiNomialCommand() {
            var command = new Command("multi-nomial");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.MultiNomial.MultiNomialRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildNaCommand() {
            var command = new Command("na");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Na.NaRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildNCommand() {
            var command = new Command("n");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.N.NRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildNegBinom_DistCommand() {
            var command = new Command("neg-binom_-dist");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.NegBinom_Dist.NegBinom_DistRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildNetworkDays_IntlCommand() {
            var command = new Command("network-days_-intl");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.NetworkDays_Intl.NetworkDays_IntlRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildNetworkDaysCommand() {
            var command = new Command("network-days");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.NetworkDays.NetworkDaysRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildNominalCommand() {
            var command = new Command("nominal");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Nominal.NominalRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildNorm_DistCommand() {
            var command = new Command("norm_-dist");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Norm_Dist.Norm_DistRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildNorm_InvCommand() {
            var command = new Command("norm_-inv");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Norm_Inv.Norm_InvRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildNorm_S_DistCommand() {
            var command = new Command("norm_-s_-dist");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Norm_S_Dist.Norm_S_DistRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildNorm_S_InvCommand() {
            var command = new Command("norm_-s_-inv");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Norm_S_Inv.Norm_S_InvRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildNotCommand() {
            var command = new Command("not");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Not.NotRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildNowCommand() {
            var command = new Command("now");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Now.NowRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildNperCommand() {
            var command = new Command("nper");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Nper.NperRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildNpvCommand() {
            var command = new Command("npv");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Npv.NpvRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildNumberValueCommand() {
            var command = new Command("number-value");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.NumberValue.NumberValueRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildOct2BinCommand() {
            var command = new Command("oct2-bin");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Oct2Bin.Oct2BinRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildOct2DecCommand() {
            var command = new Command("oct2-dec");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Oct2Dec.Oct2DecRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildOct2HexCommand() {
            var command = new Command("oct2-hex");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Oct2Hex.Oct2HexRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildOddCommand() {
            var command = new Command("odd");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Odd.OddRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildOddFPriceCommand() {
            var command = new Command("odd-f-price");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.OddFPrice.OddFPriceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildOddFYieldCommand() {
            var command = new Command("odd-f-yield");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.OddFYield.OddFYieldRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildOddLPriceCommand() {
            var command = new Command("odd-l-price");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.OddLPrice.OddLPriceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildOddLYieldCommand() {
            var command = new Command("odd-l-yield");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.OddLYield.OddLYieldRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildOrCommand() {
            var command = new Command("or");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Or.OrRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Update the navigation property functions in workbooks
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property functions in workbooks";
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
                var model = parseNode.GetObjectValue<WorkbookFunctions>();
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo);
                console.WriteLine("Success");
            }, driveItemIdOption, bodyOption);
            return command;
        }
        public Command BuildPdurationCommand() {
            var command = new Command("pduration");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Pduration.PdurationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPercentile_ExcCommand() {
            var command = new Command("percentile_-exc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Percentile_Exc.Percentile_ExcRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPercentile_IncCommand() {
            var command = new Command("percentile_-inc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Percentile_Inc.Percentile_IncRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPercentRank_ExcCommand() {
            var command = new Command("percent-rank_-exc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.PercentRank_Exc.PercentRank_ExcRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPercentRank_IncCommand() {
            var command = new Command("percent-rank_-inc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.PercentRank_Inc.PercentRank_IncRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPermutationaCommand() {
            var command = new Command("permutationa");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Permutationa.PermutationaRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPermutCommand() {
            var command = new Command("permut");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Permut.PermutRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPhiCommand() {
            var command = new Command("phi");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Phi.PhiRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPiCommand() {
            var command = new Command("pi");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Pi.PiRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPmtCommand() {
            var command = new Command("pmt");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Pmt.PmtRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPoisson_DistCommand() {
            var command = new Command("poisson_-dist");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Poisson_Dist.Poisson_DistRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPowerCommand() {
            var command = new Command("power");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Power.PowerRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPpmtCommand() {
            var command = new Command("ppmt");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Ppmt.PpmtRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPriceCommand() {
            var command = new Command("price");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Price.PriceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPriceDiscCommand() {
            var command = new Command("price-disc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.PriceDisc.PriceDiscRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPriceMatCommand() {
            var command = new Command("price-mat");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.PriceMat.PriceMatRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildProductCommand() {
            var command = new Command("product");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Product.ProductRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildProperCommand() {
            var command = new Command("proper");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Proper.ProperRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildPvCommand() {
            var command = new Command("pv");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Pv.PvRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildQuartile_ExcCommand() {
            var command = new Command("quartile_-exc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Quartile_Exc.Quartile_ExcRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildQuartile_IncCommand() {
            var command = new Command("quartile_-inc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Quartile_Inc.Quartile_IncRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildQuotientCommand() {
            var command = new Command("quotient");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Quotient.QuotientRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRadiansCommand() {
            var command = new Command("radians");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Radians.RadiansRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRandBetweenCommand() {
            var command = new Command("rand-between");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.RandBetween.RandBetweenRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRandCommand() {
            var command = new Command("rand");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Rand.RandRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRank_AvgCommand() {
            var command = new Command("rank_-avg");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Rank_Avg.Rank_AvgRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRank_EqCommand() {
            var command = new Command("rank_-eq");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Rank_Eq.Rank_EqRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRateCommand() {
            var command = new Command("rate");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Rate.RateRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildReceivedCommand() {
            var command = new Command("received");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Received.ReceivedRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildReplaceBCommand() {
            var command = new Command("replace-b");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.ReplaceB.ReplaceBRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildReplaceCommand() {
            var command = new Command("replace");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Replace.ReplaceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildReptCommand() {
            var command = new Command("rept");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Rept.ReptRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRightbCommand() {
            var command = new Command("rightb");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Rightb.RightbRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRightCommand() {
            var command = new Command("right");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Right.RightRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRomanCommand() {
            var command = new Command("roman");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Roman.RomanRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRoundCommand() {
            var command = new Command("round");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Round.RoundRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRoundDownCommand() {
            var command = new Command("round-down");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.RoundDown.RoundDownRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRoundUpCommand() {
            var command = new Command("round-up");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.RoundUp.RoundUpRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRowsCommand() {
            var command = new Command("rows");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Rows.RowsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRriCommand() {
            var command = new Command("rri");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Rri.RriRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSecCommand() {
            var command = new Command("sec");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Sec.SecRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSechCommand() {
            var command = new Command("sech");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Sech.SechRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSecondCommand() {
            var command = new Command("second");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Second.SecondRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSeriesSumCommand() {
            var command = new Command("series-sum");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.SeriesSum.SeriesSumRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSheetCommand() {
            var command = new Command("sheet");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Sheet.SheetRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSheetsCommand() {
            var command = new Command("sheets");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Sheets.SheetsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSignCommand() {
            var command = new Command("sign");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Sign.SignRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSinCommand() {
            var command = new Command("sin");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Sin.SinRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSinhCommand() {
            var command = new Command("sinh");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Sinh.SinhRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSkew_pCommand() {
            var command = new Command("skew_p");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Skew_p.Skew_pRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSkewCommand() {
            var command = new Command("skew");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Skew.SkewRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSlnCommand() {
            var command = new Command("sln");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Sln.SlnRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSmallCommand() {
            var command = new Command("small");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Small.SmallRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSqrtCommand() {
            var command = new Command("sqrt");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Sqrt.SqrtRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSqrtPiCommand() {
            var command = new Command("sqrt-pi");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.SqrtPi.SqrtPiRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildStandardizeCommand() {
            var command = new Command("standardize");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Standardize.StandardizeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildStDev_PCommand() {
            var command = new Command("st-dev_-p");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.StDev_P.StDev_PRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildStDev_SCommand() {
            var command = new Command("st-dev_-s");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.StDev_S.StDev_SRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildStDevACommand() {
            var command = new Command("st-dev-a");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.StDevA.StDevARequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildStDevPACommand() {
            var command = new Command("st-dev-p-a");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.StDevPA.StDevPARequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSubstituteCommand() {
            var command = new Command("substitute");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Substitute.SubstituteRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSubtotalCommand() {
            var command = new Command("subtotal");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Subtotal.SubtotalRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSumCommand() {
            var command = new Command("sum");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Sum.SumRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSumIfCommand() {
            var command = new Command("sum-if");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.SumIf.SumIfRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSumIfsCommand() {
            var command = new Command("sum-ifs");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.SumIfs.SumIfsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSumSqCommand() {
            var command = new Command("sum-sq");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.SumSq.SumSqRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildSydCommand() {
            var command = new Command("syd");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Syd.SydRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildT_Dist_2TCommand() {
            var command = new Command("t_-dist_2-t");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.T_Dist_2T.T_Dist_2TRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildT_Dist_RTCommand() {
            var command = new Command("t_-dist_-r-t");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.T_Dist_RT.T_Dist_RTRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildT_DistCommand() {
            var command = new Command("t_-dist");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.T_Dist.T_DistRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildT_Inv_2TCommand() {
            var command = new Command("t_-inv_2-t");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.T_Inv_2T.T_Inv_2TRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildT_InvCommand() {
            var command = new Command("t_-inv");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.T_Inv.T_InvRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTanCommand() {
            var command = new Command("tan");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Tan.TanRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTanhCommand() {
            var command = new Command("tanh");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Tanh.TanhRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTbillEqCommand() {
            var command = new Command("tbill-eq");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.TbillEq.TbillEqRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTbillPriceCommand() {
            var command = new Command("tbill-price");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.TbillPrice.TbillPriceRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTbillYieldCommand() {
            var command = new Command("tbill-yield");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.TbillYield.TbillYieldRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTCommand() {
            var command = new Command("t");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.T.TRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTextCommand() {
            var command = new Command("text");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Text.TextRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTimeCommand() {
            var command = new Command("time");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Time.TimeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTimevalueCommand() {
            var command = new Command("timevalue");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Timevalue.TimevalueRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTodayCommand() {
            var command = new Command("today");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Today.TodayRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTrimCommand() {
            var command = new Command("trim");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Trim.TrimRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTrimMeanCommand() {
            var command = new Command("trim-mean");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.TrimMean.TrimMeanRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTrueCommand() {
            var command = new Command("true");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.True.TrueRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTruncCommand() {
            var command = new Command("trunc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Trunc.TruncRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildTypeCommand() {
            var command = new Command("type");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Type.TypeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildUnicharCommand() {
            var command = new Command("unichar");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Unichar.UnicharRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildUnicodeCommand() {
            var command = new Command("unicode");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Unicode.UnicodeRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildUpperCommand() {
            var command = new Command("upper");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Upper.UpperRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildUsdollarCommand() {
            var command = new Command("usdollar");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Usdollar.UsdollarRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildValueCommand() {
            var command = new Command("value");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Value.ValueRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildVar_PCommand() {
            var command = new Command("var_-p");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Var_P.Var_PRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildVar_SCommand() {
            var command = new Command("var_-s");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Var_S.Var_SRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildVarACommand() {
            var command = new Command("var-a");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.VarA.VarARequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildVarPACommand() {
            var command = new Command("var-p-a");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.VarPA.VarPARequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildVdbCommand() {
            var command = new Command("vdb");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Vdb.VdbRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildVlookupCommand() {
            var command = new Command("vlookup");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Vlookup.VlookupRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildWeekdayCommand() {
            var command = new Command("weekday");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Weekday.WeekdayRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildWeekNumCommand() {
            var command = new Command("week-num");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.WeekNum.WeekNumRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildWeibull_DistCommand() {
            var command = new Command("weibull_-dist");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Weibull_Dist.Weibull_DistRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildWorkDay_IntlCommand() {
            var command = new Command("work-day_-intl");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.WorkDay_Intl.WorkDay_IntlRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildWorkDayCommand() {
            var command = new Command("work-day");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.WorkDay.WorkDayRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildXirrCommand() {
            var command = new Command("xirr");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Xirr.XirrRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildXnpvCommand() {
            var command = new Command("xnpv");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Xnpv.XnpvRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildXorCommand() {
            var command = new Command("xor");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Xor.XorRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildYearCommand() {
            var command = new Command("year");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Year.YearRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildYearFracCommand() {
            var command = new Command("year-frac");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.YearFrac.YearFracRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildYieldCommand() {
            var command = new Command("yield");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Yield.YieldRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildYieldDiscCommand() {
            var command = new Command("yield-disc");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.YieldDisc.YieldDiscRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildYieldMatCommand() {
            var command = new Command("yield-mat");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.YieldMat.YieldMatRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildZ_TestCommand() {
            var command = new Command("z_-test");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Functions.Z_Test.Z_TestRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new FunctionsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public FunctionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/functions{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new FunctionsRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public FunctionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/functions{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property functions for workbooks
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
        /// Get functions from workbooks
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
        /// Update the navigation property functions in workbooks
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WorkbookFunctions body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Delete navigation property functions for workbooks
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
        /// Get functions from workbooks
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<WorkbookFunctions> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<WorkbookFunctions>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property functions in workbooks
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(WorkbookFunctions model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Get functions from workbooks</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
