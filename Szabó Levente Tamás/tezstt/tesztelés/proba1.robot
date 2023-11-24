*** Settings ***
Library           SeneliumLibary
Library           Selenium2Library

*** Test Cases ***
próba
    Open Browser    https://www.mikrosat.hu    edge
    Click Element    //*[@id="container"]/head
    Input Text    Selenium2Library.Input.Text
    Input Password
    Close Browser
