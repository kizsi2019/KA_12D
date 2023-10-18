*** Settings ***
Library           Selenium2Library
Library           SeleniumLibrary

*** Test Cases ***
teszt1
    Open Browser    https://mikrosat.hu    chrome
    Click Element    //*[@id="container"]/header/div/div/div[2]/div/div[2]/div[3]
    Input Text    //*[@id="shop_user_login"]
    Input Password    //*[@id="shop_pass_login"]






    Close Browser
