using System;
using System.Linq.Expressions;

using NHibernate.Impl;

namespace NHibernate.Criterion
{
	public static class ProjectionsExtensions
	{
		/// <summary>
		/// Create an alias for a projection
		/// </summary>
		/// <param name="projection">the projection instance</param>
		/// <param name="alias">LambdaExpression returning an alias</param>
		/// <returns>return NHibernate.Criterion.IProjection</returns>
		public static IProjection WithAlias(this IProjection			projection,
											Expression<Func<object>>    alias)
		{
			string aliasContainer = ExpressionProcessor.FindPropertyExpression(alias.Body);
			return Projections.Alias(projection, aliasContainer);
		}

		/// <summary>
		/// Project SQL function year()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static int YearPart(this DateTime dateTimeProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessYearPart(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			return Projections.SqlFunction("year", NHibernateUtil.Int32, property);
		}

		/// <summary>
		/// Project SQL function day()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static int DayPart(this DateTime dateTimeProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessDayPart(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			return Projections.SqlFunction("day", NHibernateUtil.Int32, property);
		}

		/// <summary>
		/// Project SQL function month()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static int MonthPart(this DateTime dateTimeProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessMonthPart(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			return Projections.SqlFunction("month", NHibernateUtil.Int32, property);
		}

		/// <summary>
		/// Project SQL function hour()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static int HourPart(this DateTime dateTimeProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessHourPart(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			return Projections.SqlFunction("hour", NHibernateUtil.Int32, property);
		}

		/// <summary>
		/// Project SQL function minute()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static int MinutePart(this DateTime dateTimeProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessMinutePart(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			return Projections.SqlFunction("minute", NHibernateUtil.Int32, property);
		}

		/// <summary>
		/// Project SQL function second()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static int SecondPart(this DateTime dateTimeProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessSecondPart(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			return Projections.SqlFunction("second", NHibernateUtil.Int32, property);
		}

		/// <summary>
		/// Project SQL function sqrt()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static double Sqrt(this double numericProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		/// <summary>
		/// Project SQL function sqrt()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static double Sqrt(this int numericProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		/// <summary>
		/// Project SQL function sqrt()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static double Sqrt(this long numericProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		/// <summary>
		/// Project SQL function sqrt()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static double Sqrt(this decimal numericProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		/// <summary>
		/// Project SQL function sqrt()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static double Sqrt(this byte numericProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessSqrt(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			return Projections.SqlFunction("sqrt", NHibernateUtil.Double, property);
		}

		/// <summary>
		/// Project SQL function lower()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static string Lower(this string stringProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessLower(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			return Projections.SqlFunction("lower", NHibernateUtil.String, property);
		}

		/// <summary>
		/// Project SQL function upper()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static string Upper(this string stringProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessUpper(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			return Projections.SqlFunction("upper", NHibernateUtil.String, property);
		}

		/// <summary>
		/// Project SQL function abs()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static int Abs(this int numericProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessIntAbs(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			return Projections.SqlFunction("abs", NHibernateUtil.Int32, property);
		}

		/// <summary>
		/// Project SQL function abs()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static Int64 Abs(this Int64 numericProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessInt64Abs(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			return Projections.SqlFunction("abs", NHibernateUtil.Int64, property);
		}

		/// <summary>
		/// Project SQL function abs()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static double Abs(this double numericProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessDoubleAbs(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			return Projections.SqlFunction("abs", NHibernateUtil.Double, property);
		}

		/// <summary>
		/// Project SQL function trim()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static string TrimStr(this string stringProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessTrimStr(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			return Projections.SqlFunction("trim", NHibernateUtil.String, property);
		}

		/// <summary>
		/// Project SQL function length()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static int StrLength(this string stringProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessStrLength(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			return Projections.SqlFunction("length", NHibernateUtil.String, property);
		}

		/// <summary>
		/// Project SQL function bit_length()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static int BitLength(this string stringProperty)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessBitLength(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			return Projections.SqlFunction("bit_length", NHibernateUtil.String, property);
		}

		/// <summary>
		/// Project SQL function substring()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static string Substr(this string stringProperty, int startIndex, int length)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessSubstr(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			object startIndex = ExpressionProcessor.FindValue(methodCallExpression.Arguments[1]);
			object length = ExpressionProcessor.FindValue(methodCallExpression.Arguments[2]);
			return Projections.SqlFunction("substring", NHibernateUtil.String, property, Projections.Constant(startIndex), Projections.Constant(length));
		}

		/// <summary>
		/// Project SQL function locate()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static int CharIndex(this string stringProperty, string theChar, int startLocation)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessCharIndex(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			object theChar = ExpressionProcessor.FindValue(methodCallExpression.Arguments[1]);
			object startLocation = ExpressionProcessor.FindValue(methodCallExpression.Arguments[2]);
			return Projections.SqlFunction("locate", NHibernateUtil.String, Projections.Constant(theChar), property, Projections.Constant(startLocation));
		}

		/// <summary>
		/// Project SQL function coalesce()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static T Coalesce<T>(this T objectProperty, T replaceValueIfIsNull)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		/// <summary>
		/// Project SQL function coalesce()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static T? Coalesce<T>(this T? objectProperty, T replaceValueIfIsNull) where T : struct
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessCoalesce(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			object replaceValueIfIsNull = ExpressionProcessor.FindValue(methodCallExpression.Arguments[1]);
			return Projections.SqlFunction("coalesce", NHibernateUtil.Object, property, Projections.Constant(replaceValueIfIsNull));
		}

		/// <summary>
		/// Project SQL function mod()
		/// Note: throws an exception outside of a QueryOver expression
		/// </summary>
		public static int Mod(this int numericProperty, int divisor)
		{
			throw new Exception("Not to be used directly - use inside QueryOver expression");
		}

		internal static IProjection ProcessMod(MethodCallExpression methodCallExpression)
		{
			IProjection property = ExpressionProcessor.FindMemberProjection(methodCallExpression.Arguments[0]).AsProjection();
			object divisor = ExpressionProcessor.FindValue(methodCallExpression.Arguments[1]);
			return Projections.SqlFunction("mod", NHibernateUtil.Int32, property, Projections.Constant(divisor));
		}
	}
}
