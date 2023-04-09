# download github logo to  and save to a png file

import requests

url = 'https://github.githubassets.com/images/modules/logos_page/GitHub-Mark.png'
r = requests.get(url)

with open('github.png', 'wb') as f:
    f.write(r.content)

# download a githuhub octodex image from the web and save to a file

import requests

url = 'https://octodex.github.com/images/labtocat.png'
r = requests.get(url)

with open('labtocat.png', 'wb') as f:
    f.write(r.content)

# turn image upside down

from PIL import Image

img = Image.open('labtocat.png')
img = img.transpose(Image.FLIP_TOP_BOTTOM)
img.save('labtocat_flipped.png')

# change background color to blue

from PIL import Image

img = Image.open('labtocat.png')
img = img.convert('RGBA')

datas = img.getdata()

newData = []
for item in datas:
    if item[0] == 255 and item[1] == 255 and item[2] == 255:
        newData.append((0, 0, 255, 255))
    else:
        newData.append(item)

img.putdata(newData)
img.save('labtocat_flipped_blue.png', "PNG")

# add azure logo to image

from PIL import Image

img = Image.open('labtocat.png')
img = img.convert('RGBA')

logo = Image.open('github.png')
logo = logo.convert('RGBA')

box = (0, 0, 100, 100)
img.paste(logo, box, logo)
img.save('labtocat_flipped_blue_azure.png', "PNG")
