*** Settings ***
Library           Selenium2Library

*** Test Cases ***
elso
    Open Browser    https://www.mikrosat.hu    chrome
    Click Element    //*[@id="container"]/header/div/div/div[2]/div/div[2]/div[3]
    Input Text    //*[@id="shop_user_login"]    proba@gggg.com
    Input Text    //*[@id="shop_pass_login"]    vjkwij
    Click Button
