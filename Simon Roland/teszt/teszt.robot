*** Settings ***
Library           Selenium2Library

*** Test Cases ***
teszt1
    Open Browser    https://www.mikrosat.hu    firefox
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    igen@gmail.com
    Input Password    //*[@id="Password"]    2004-05-24
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

teszt2
    Open Browser    https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dkreta-web%26response_type%3Dcode%26scope%3Dopenid%26state%3DOpenIdConnect.AuthenticationProperties%253DHTwIhXrOnWco7vz9bb8sUwxMO-XrCngxrtCbkkbkQJ9lWTMY2C3XS_77H8f4daQvPZwQFa6Xk3fYkBn7ccxzaPfILGrjks4ubwBXHJFU77ZGoc2fZ-aLdbqyTeiZ_Q9TQYzdGypfXPh0ec-MgO3Fxw%26response_mode%3Dform_post%26nonce%3D638362455066118853.NWI4OTA1M2MtMmY4Mi00NTdkLTljM2MtYmNjMDA5N2NkN2Y3YTI2ZmQ1YmMtNTU5Yy00Y2UwLWE5MzItYzQ5NjMxZjQ5ZmYx%26institute_code%3Dbgeszc-katona%26institute_data%3DeyJuZXh0X3VwZGF0ZV9kYXRlX3RpbWUiOiIyMDIzLjExLjI4LiAyMjowMCIsImlzX3N6aXJfaW5zdGl0dXRlIjpmYWxzZSwiaXNfbGljZW5jZV92YWxpZCI6dHJ1ZSwiaXNfYXJjaGl2ZSI6ZmFsc2UsImlzX2Nzb2trZW50ZXR0X2dvbmR2aXNlbG8iOnRydWUsImlzX2ludGV6bWVueV9yb3ZpZG5ldiI6dHJ1ZSwiaXNfc3VjY2Vzc19hdXRob3JpemVkX2RhdGUiOmZhbHNlfQ%253D%253D%26prompt%3Dlogin%26redirect_uri%3Dhttps%253A%252F%252Fbgeszc-katona.e-kreta.hu%26x-client-SKU%3DID_NET461%26x-client-ver%3D5.3.0.0%26suppressed_prompt%3Dlogin    firefox
    Capture Page Screenshot
    Input text    //*[@id="UserName"]    72464888336
    Input Password    //*[@id="Password"]    2004-05-24
    Click Button    //*[@id="submit-btn"]
    Capture Page Screenshot
    Close Browser

teszt3

teszt
    Open Browser    https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dkreta-web%26response_type%3Dcode%26scope%3Dopenid%26state%3DOpenIdConnect.AuthenticationProperties%253DHTwIhXrOnWco7vz9bb8sUwxMO-XrCngxrtCbkkbkQJ9lWTMY2C3XS_77H8f4daQvPZwQFa6Xk3fYkBn7ccxzaPfILGrjks4ubwBXHJFU77ZGoc2fZ-aLdbqyTeiZ_Q9TQYzdGypfXPh0ec-MgO3Fxw%26response_mode%3Dform_post%26nonce%3D638362455066118853.NWI4OTA1M2MtMmY4Mi00NTdkLTljM2MtYmNjMDA5N2NkN2Y3YTI2ZmQ1YmMtNTU5Yy00Y2UwLWE5MzItYzQ5NjMxZjQ5ZmYx%26institute_code%3Dbgeszc-katona%26institute_data%3DeyJuZXh0X3VwZGF0ZV9kYXRlX3RpbWUiOiIyMDIzLjExLjI4LiAyMjowMCIsImlzX3N6aXJfaW5zdGl0dXRlIjpmYWxzZSwiaXNfbGljZW5jZV92YWxpZCI6dHJ1ZSwiaXNfYXJjaGl2ZSI6ZmFsc2UsImlzX2Nzb2trZW50ZXR0X2dvbmR2aXNlbG8iOnRydWUsImlzX2ludGV6bWVueV9yb3ZpZG5ldiI6dHJ1ZSwiaXNfc3VjY2Vzc19hdXRob3JpemVkX2RhdGUiOmZhbHNlfQ%253D%253D%26prompt%3Dlogin%26redirect_uri%3Dhttps%253A%252F%252Fbgeszc-katona.e-kreta.hu%26x-client-SKU%3DID_NET461%26x-client-ver%3D5.3.0.0%26suppressed_prompt%3Dlogin    firefox
    Capture Page Screenshot
    Input text    //*[@id="UserName"]    72464888336
    Input Password    //*[@id="Password"]    2004-05-24
    Click Button    //*[@id="submit-btn"]
    Click Element    //*[]
    Capture    Page Screenshot
    Close Browser
