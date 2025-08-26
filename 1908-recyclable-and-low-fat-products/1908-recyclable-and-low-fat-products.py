import pandas as pd

def find_products(products: pd.DataFrame) -> pd.DataFrame:
    find_products_result = products[(products["low_fats"] == "Y") & (products["recyclable"] == "Y")]
    return find_products_result[["product_id"]]