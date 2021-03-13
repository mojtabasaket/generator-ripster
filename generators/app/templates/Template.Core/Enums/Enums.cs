namespace Template.Core.Enums
{
    public class Enums
    {
        public enum ErroreCode
        {
            /// <summary>
            /// مشخص نشده
            /// </summary>
            NONE = 0,
            /// <summary>
            /// یافت نشد
            /// </summary>
            NOT_EXIST = 1,
            /// <summary>
            /// وجود  دارد
            /// </summary>
            IS_EXISTS = 2,
            /// <summary>
            /// نامعتبر
            /// </summary>
            NOT_VALID = 3,

            #region Account 1001 - 1099

            /// <summary>
            /// حساب غیر فعال می باشد
            /// </summary>
            ACCOUNT_IS_INACTIVE = 1001,

            /// <summary>
            /// حساب یافت نشد
            /// </summary>
            ACCOUNT_NOT_FOUND = 1002,

            /// <summary>
            /// موجودی حساب کافی نیست
            /// </summary>
            ACCOUNT_BALANCE_NOT_ENOUGH = 1003,

            /// <summary>
            /// باقیمانده حساب یافت نشد
            /// </summary>
            ACCOUNT_BALANCE_NOT_FOUND = 1004,


            /// <summary>
            /// تراکنشی برای انتقال یافت نشد
            /// </summary>
            /// AccountJournalDetail
            ACCOUNT_JOURNAL_DETAIL_NOT_FOUND_TO_REGISTER = 1005,
            #endregion

            #region Customer 1100 - 1199

            /// <summary>
            /// گروه مشتری غیر فعال می باشد
            /// </summary>
            CUSTOMERGROUP_IS_INACTIVE = 1100,

            /// <summary>
            /// مشتری یافت نشد
            /// </summary>
            CUSTOMER_NOT_FOUND = 1101,

            /// <summary>
            /// مشتری غیر  فعال شده است
            /// </summary>
            CUSTOMER_IS_INACTIVE = 1102,

            /// <summary>
            /// صورت حساب مشتری نا معتبر می باشد
            /// </summary>
            STATEMENT_NUMBER_NOT_VALID = 1103,

            /// <summary>
            /// مشتری قبلا ثبت نام شده است
            /// </summary>
            CUSTOMER_IS_EXISTS = 1104,

            /// <summary>
            /// گروه مشتری قرارداد فعالی ندارد
            /// </summary>
            CUSTOMERGROUP_HAS_NO_CONTRACT = 1105,

            /// <summary>
            /// مشتری نا معتبر است
            /// </summary>
            CUSTOMER_NOT_VALID = 1106,

            /// <summary>
            /// صورت حساب  تسویه شده است
            /// </summary>
            STATEMENT_IS_CLEAR = 1107,


            INVALID_REQUEST_CREDIT = 1108,

            /// <summary>
            /// مبلغ تسویه نا معتبر است
            /// </summary>
            INVALID_STATEMENT_AMOUNT = 1109,

            PROFILE_HASDEFAULT_CREDIT = 1110,

            REQUEST_CREDIT_NOT_IN_RANGE = 1111,

            REQUEST_CREDIT_OUT_OF_RANGE_FINANCIER = 1112,

            /// <summary>
            ///  مشتری قرارداد فعالی ندارد
            /// </summary>
            CUSTOMER_HAS_NO_CONTRACT = 1113,


            PAYMENTID_NOT_VALID = 1114,
            #endregion

            #region Transfer 1200 - 1299
            /// <summary>
            /// مدل تراکنش یافت نشد
            /// </summary>
            TRANSACTION_MODEL_NOT_FOUND = 1200,
            /// <summary>
            /// تراکنش یافت نشد
            /// </summary>
            TRANSACTION_NOT_FOUND = 1201,
            /// <summary>
            /// تراکنش قبلا تکمیل شده است
            /// </summary>
            TRANSACTION_ALREADY_HAS_BEEN_COMPLETED = 1203,
            /// <summary>
            /// شماره پیگیری تکراری می باشد
            /// </summary>
            DUPLICATE_REQUEST_NUMBER = 1204,
            /// <summary>
            /// شماره پیگیری هاست تکراری می باشد
            /// </summary>
            DUPLICATE_HOST_REQUEST_NUMBER = 1205,

            /// <summary>
            /// شماره پیگیری تکراری می باشد
            /// </summary>
            PAYMENTID_EXIST = 1206,

            /// <summary>
            /// نوع تراکنش مجاز نمی باشد
            /// </summary>
            TRANSFER_TYPE_NOT_VALID = 1207,

            /// <summary>
            /// نوع تراکنش وجود ندارد
            /// </summary>
            TRANSFER_TYPE_NOT_FOUND = 1208,

            /// <summary>
            /// ارائه دهنده خدمت یافت نشد
            /// </summary>
            PROVIDER_NOT_FOUND = 1209,

            /// <summary>
            /// زمان تراکنش نامعتبر می باشد
            /// </summary>
            TRANSACTION_DATE_NOT_VALID = 1210,
            #endregion

            #region Profile 1300 - 1399

            /// <summary>
            /// پروفایل یافت نشد
            /// </summary>
            PROFILE_NOT_FOUND = 1300,

            /// <summary>
            /// پروفایل اعتباری یافت نشد
            /// </summary>
            CREDIT_PROFILE_NOT_FOUND = 1301,

            /// <summary>
            /// پروفایل تسهیلات یافت نشد
            /// </summary>
            FACILITIES_PROFILE_NOT_FOUND = 1302,

            #endregion

            #region Policy 1400 - 1499

            /// <summary>
            /// تعداد اقساط بیشتر از حد مجاز می باشد
            /// </summary>
            INSTALLMENT_COUNT_CEIL_HAS_NOT_BEEN_OBSERVED = 1400,

            /// <summary>
            /// تعداد اقساط کمتر از حد مجاز می باشد
            /// </summary>
            INSTALLMENT_COUNT_FLOOR_HAS_NOT_BEEN_OBSERVED = 1401,

            /// <summary>
            /// مبلغ تسهیلات کمتر از حد مجاز می باشد
            /// </summary>
            MIN_FACILITY_AMOUNT_HAS_NOT_BEEN_OBSERVED = 1402,

            /// <summary>
            /// مبلغ تسهیلات بیشتر از حد مجاز می باشد
            /// </summary>
            MAX_TRANSACTION_AMOUNT_HAS_NOT_BEEN_OBSERVED = 1403,

            /// <summary>
            /// مبلغ خرید کمتر از حد مجاز می باشد
            /// </summary>
            MIN_TRANSACTION_AMOUNT_HAS_NOT_BEEN_OBSERVED = 1404,

            /// <summary>
            /// مبلغ خرید روزانه بیشتر از حد مجاز می باشد
            /// </summary>
            MAX_TRANSACTION_AMOUNT_PERDAY_HAS_NOT_BEEN_OBSERVED = 1405,

            /// <summary>
            /// تعداد خرید روزانه بیشتر از حد مجاز می باشد
            /// </summary>
            MAX_TRANSACTION_COUNT_PERDAY_HAS_NOT_BEEN_OBSERVED = 1406,

            /// <summary>
            /// این سرویس برای پروفایل شما مجاز نمی باشد
            /// </summary>
            SERVICEPOLICY_NOT_ALLOWED = 1407,
            #endregion

            #region File 1500 - 1599

            /// <summary>
            /// آدرس فایل یافت نشد
            /// </summary>
            FILEPATH_NOT_FOUND = 1500,

            #endregion
            #region Contract 1600 - 1699

            /// <summary>
            /// شماره قرارداد های ارسالی تکراری میباشد
            /// </summary>
            EXISTS_CONTRACT = 1600,

            /// <summary>
            /// 
            /// </summary>
            EXISTS_ACTIVE_CONTRACT_CUSTOMER_GROUP = 1601,

            /// <summary>
            /// قرارداد حقیقی فقط یک زیر قرارداد فعال می تواند داشته باشد
            /// </summary>
            EXISTS_ACTIVE_CONTRACT = 1602,
            #endregion

            #region Client 1700 - 1799

            /// <summary>
            /// آدرس فایل یافت نشد
            /// </summary>
            CLIENT_ERROR = 1700,

            #endregion



        }
    }
}
