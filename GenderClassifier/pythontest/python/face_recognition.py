from cv2 import *
import sys
import re


xmlPath = "./pythontest/haarcascade_frontalface_default.xml"


imagePath =sys.argv[1]

m1 = re.search('[\w-]+\.', imagePath)
m2 = re.search('[\w-]+', m1.group(0))
imageName =  m2.group(0)
faceCascade = CascadeClassifier(xmlPath)
image = imread(imagePath)
height, width = image.shape[:2]

gray = cvtColor(image, COLOR_BGR2GRAY)

faces = faceCascade.detectMultiScale(gray, 1.3, 5)

for (x, y, w, h) in faces:
    rectangle(image, (x, y), (x+w, y+h), (0, 255, 0), 2)
    
imwrite('./pythontest/tmp/' + imageName +'.jpg', image)

destroyAllWindows()

