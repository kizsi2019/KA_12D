*** Settings ***
Library           Selenium2Library

*** Test Cases ***
test1
    Open Browser    https:\\www.mikrosat.hu    firefox
    Click Element    //*[@id="container"]/header/div/div/div[2]/div/div[2]/div[3]/div/div[2]/form/div[1]
    Input Text    //*[@id="shop_user_login"]
    Input Text    //*[@id="shop_pass_login"]
    Close Browser
