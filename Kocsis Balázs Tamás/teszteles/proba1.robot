*** Settings ***
Library           Selenium2Library
Library           SeleniumLibrary

*** Test Cases ***
teszt1
    Open Browser    https:\\mikrosat.hu\    Chrome
    Click Element
    Input Text
    Input Password
    Close Browser
