*** Settings ***
Library           Selenium2Library

*** Test Cases ***
test1
    open browser    https://www.mikrosat.hu    chrome
    click element    //*[@id="container"]/header/div/div/div[2]/div/div[2]/div[3]
    close browser
