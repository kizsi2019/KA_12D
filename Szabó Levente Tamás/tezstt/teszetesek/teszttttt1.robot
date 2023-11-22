*** Settings ***
Library           Selenium2Library

*** Test Cases ***
Login Test
    Open Browser    https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dkreta-web%26response_type%3Dcode%26scope%3Dopenid%26state%3DOpenIdConnect.AuthenticationProperties%253DfhUAeXXGtI0u8MOe0a9K6JIQEqk0Ibgk9V6Zinxa5zINBzTUITCZ_AgGZ6qzYODarRRJ9VrepID3PcXTKAZVWoVOJcqjDGk04iyRwPOUgvAUCerx-1fUdJp5pBuskGnJ23n9_TQQLkMhlcWfIDIGZA%26response_mode%3Dform_post%26nonce%3D638362449746709506.YjMyNDUwMjgtOGUyNy00NTViLWE5ODAtMzkzNmUwZjk5YjY5YjgwZjIzZTItZDVjYy00NjUwLWJiMDYtYTY0YzhiZWRlODMw%26institute_code%3Dbgeszc-katona%26institute_data%3DeyJuZXh0X3VwZGF0ZV9kYXRlX3RpbWUiOiIyMDIzLjExLjI4LiAyMjowMCIsImlzX3N6aXJfaW5zdGl0dXRlIjpmYWxzZSwiaXNfbGljZW5jZV92YWxpZCI6dHJ1ZSwiaXNfYXJjaGl2ZSI6ZmFsc2UsImlzX2Nzb2trZW50ZXR0X2dvbmR2aXNlbG8iOnRydWUsImlzX2ludGV6bWVueV9yb3ZpZG5ldiI6dHJ1ZSwiaXNfc3VjY2Vzc19hdXRob3JpemVkX2RhdGUiOmZhbHNlfQ%253D%253D%26prompt%3Dlogin%26redirect_uri%3Dhttps%253A%252F%252Fbgeszc-katona.e-kreta.hu%26x-client-SKU%3DID_NET461%26x-client-ver%3D5.3.0.0%26suppressed_prompt%3Dlogin    firefox
    Capture Page Screenshot
    Click Element    //*[@id="submit-btn"]
    Input text    //*[@id="UserName"]    72447568852
    Input Password    //*[@id="Password"]    2003-10-28
    Click Button    //*[@id="submit-btn"]
    Wait Until Page Contains    Kijelentkezés    20s
    Capture Page Screenshot
    Close Browser
