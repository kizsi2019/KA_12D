*** Settings ***
Library           Selenium2Library

*** Test Cases ***
Teszt1
    Open Browser    https://www.mikrosat.hu    chrome
    Click Element    //*[@id="container"]/header/div/div/div[2]/div/div[2]/div[3]
    Input Text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    jelszo
    Click Button    //*[contains(text(), "Belép")]
    Close Browser
