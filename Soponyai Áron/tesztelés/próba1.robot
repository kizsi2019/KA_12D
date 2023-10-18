*** Settings ***
Library           Selenium2Library

*** Test Cases ***
teszt1
    Open browser    https://www.mikrosat.hu    chrome
    Click Element    //*[@id="container"]/header/div/div/div[2]/div/div[2]/div[3]
    Input Text    //*[@id="shop_user_login"]    email
    Input Text    //*[@id="shop_pass_login"]    jelszo
    Click Element    //*[@id="container"]/header/div/div/div[2]/div/div[2]/div[3]/div/div[2]/form/div[1]/button

    Close browser
