import pytesseract as pt
import os
import glob

screenshots_list = glob.glob("C:/Users/BoldisAron/Desktop/fasza/screenshots/*.png")
latest_sc = max(screenshots_list, key=os.path.getctime)
string = pt.image_to_string(latest_sc)

with open("output.txt", "w") as f:
    f.write(string)
print("Succes")
