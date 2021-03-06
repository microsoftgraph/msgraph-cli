# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------


def cf_financials_beta_cl(cli_ctx, *_):
    from msgraph.cli.core.commands.client_factory import get_mgmt_service_client
    from azext_financials_beta.vendored_sdks.financials import Financials
    return get_mgmt_service_client(cli_ctx,
                                   Financials,
                                   subscription_bound=False,
                                   base_url_bound=False)


def cf_financial_financial(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_financials


def cf_financial(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials


def cf_financial_company(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies


def cf_financial_company_customer_payment_journal(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_customer_payment_journals


def cf_financial_company_customer_payment_journal_customer_payment(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_customer_payment_journals_customer_payments


def cf_financial_company_customer_payment_journal_customer_payment_customer(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_customer_payment_journals_customer_payments_customer


def cf_financial_company_customer_payment(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_customer_payments


def cf_financial_company_customer_payment_customer(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_customer_payments_customer


def cf_financial_company_customer(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_customers


def cf_financial_company_dimension(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_dimensions


def cf_financial_company_employee(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_employees


def cf_financial_company_general_ledger_entry(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_general_ledger_entries


def cf_financial_company_item(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_items


def cf_financial_company_journal_line(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_journal_lines


def cf_financial_company_journal(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_journals


def cf_financial_company_journal_journal_line(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_journals_journal_lines


def cf_financial_company_purchase_invoice_line(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_purchase_invoice_lines


def cf_financial_company_purchase_invoice_line_item(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_purchase_invoice_lines_item


def cf_financial_company_purchase_invoice(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_purchase_invoices


def cf_financial_company_purchase_invoice_purchase_invoice_line(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_purchase_invoices_purchase_invoice_lines


def cf_financial_company_purchase_invoice_purchase_invoice_line_item(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_purchase_invoices_purchase_invoice_lines_item


def cf_financial_company_purchase_invoice_vendor(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_purchase_invoices_vendor


def cf_financial_company_sale_credit_memo_line(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_credit_memo_lines


def cf_financial_company_sale_credit_memo_line_item(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_credit_memo_lines_item


def cf_financial_company_sale_credit_memo(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_credit_memos


def cf_financial_company_sale_credit_memo_customer(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_credit_memos_customer


def cf_financial_company_sale_credit_memo_sale_credit_memo_line(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_credit_memos_sales_credit_memo_lines


def cf_financial_company_sale_credit_memo_sale_credit_memo_line_item(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_credit_memos_sales_credit_memo_lines_item


def cf_financial_company_sale_invoice_line(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_invoice_lines


def cf_financial_company_sale_invoice_line_item(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_invoice_lines_item


def cf_financial_company_sale_invoice(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_invoices


def cf_financial_company_sale_invoice_customer(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_invoices_customer


def cf_financial_company_sale_invoice_sale_invoice_line(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_invoices_sales_invoice_lines


def cf_financial_company_sale_invoice_sale_invoice_line_item(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_invoices_sales_invoice_lines_item


def cf_financial_company_sale_order_line(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_order_lines


def cf_financial_company_sale_order_line_item(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_order_lines_item


def cf_financial_company_sale_order(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_orders


def cf_financial_company_sale_order_customer(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_orders_customer


def cf_financial_company_sale_order_sale_order_line(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_orders_sales_order_lines


def cf_financial_company_sale_order_sale_order_line_item(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_orders_sales_order_lines_item


def cf_financial_company_sale_quote_line(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_quote_lines


def cf_financial_company_sale_quote_line_item(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_quote_lines_item


def cf_financial_company_sale_quote(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_quotes


def cf_financial_company_sale_quote_customer(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_quotes_customer


def cf_financial_company_sale_quote_sale_quote_line(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_quotes_sales_quote_lines


def cf_financial_company_sale_quote_sale_quote_line_item(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_sales_quotes_sales_quote_lines_item


def cf_financial_company_vendor(cli_ctx, *_):
    return cf_financials_beta_cl(cli_ctx).financials_companies_vendors
