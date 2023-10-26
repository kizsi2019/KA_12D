*** Settings ***
Library           Selenium2Library

*** Test Cases ***
teszt1
    Open Browser    https://www.mikrosat.hu    chrome
    Click Element    //*[@id="container"]/header/div/div/div[2]/div/div[2]/div[3]
    Input Text    //*[@id="shop_user_login"]    proba@ggg.hu
    Input Text    //*[@id="shop_pass_login"]    ddeee

    Close Browser
