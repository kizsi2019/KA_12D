*** Settings ***
Library           Selenium2Library

*** Test Cases ***
test1
    Open Browser    https://www.mikrosat.hu    firefox
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    email@email.hu
    Input Password    //*[@id="shop_pass_login"]    nagyontitkosjelszo
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

test2
    Open Browser    https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dkreta-web%26response_type%3Dcode%26scope%3Dopenid%26state%3DOpenIdConnect.AuthenticationProperties%253D3ixsQYIPA7YkAPTlESI8-shy2f9Kpa_I7h-m57fDsS_RLSKc6JThakeal3v88WeuuggkhAmyoq2F04kE4ObpQq3b7S-R3tzHLtWcrTakRQmUCrLEHCBsrMaZ2uN7X-He54tjecBjli_PSTSw_NZJNA%26response_mode%3Dform_post%26nonce%3D638362456005080297.YWE5NDUzMWYtOWJkMC00YWRkLThkODUtMGRiNTljOTI0MmYxMjQ5ZGE3OTQtNmRhMC00Yzc1LTg4NWEtOThhZDVjYWFhN2E5%26institute_code%3Dbgeszc-katona%26institute_data%3DeyJuZXh0X3VwZGF0ZV9kYXRlX3RpbWUiOiIyMDIzLjExLjI4LiAyMjowMCIsImlzX3N6aXJfaW5zdGl0dXRlIjpmYWxzZSwiaXNfbGljZW5jZV92YWxpZCI6dHJ1ZSwiaXNfYXJjaGl2ZSI6ZmFsc2UsImlzX2Nzb2trZW50ZXR0X2dvbmR2aXNlbG8iOnRydWUsImlzX2ludGV6bWVueV9yb3ZpZG5ldiI6dHJ1ZSwiaXNfc3VjY2Vzc19hdXRob3JpemVkX2RhdGUiOmZhbHNlfQ%253D%253D%26prompt%3Dlogin%26redirect_uri%3Dhttps%253A%252F%252Fbgeszc-katona.e-kreta.hu%26x-client-SKU%3DID_NET461%26x-client-ver%3D5.3.0.0%26suppressed_prompt%3Dlogin
    Capture Page Screenshot
    Input text    //*[@id="UserName"]    72460112037
    Input Password    //*[@id="Password"]    jelszo
    Click Button    //*[@id="submit-btn")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser
