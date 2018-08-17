gh:
	#git rm -r csv
	#git rm -r doc
	R CMD BATCH Rdatasets.R
	git add csv
	git add doc
	git add datasets.html
	git add datasets.csv
	git add Rdatasets.R
	vim datasets.csv
	vim README.rst
	git add README.rst
	cd doc 
	sh ../rst.sh

ghpages:
	git checkout master csv
	git checkout master doc
	git checkout master Rdatasets.R
	git checkout master README.rst
	git checkout master datasets.html
	git checkout master datasets.csv
	sed -i '.bak' 's/https:\/\/raw.github.com\/vincentarelbundock\/Rdatasets\/master\///g' datasets.html 
	git add csv
	git add doc
	git add datasets.html
	git add datasets.csv
	git add Rdatasets.R
	vim README.rst
	vim index.html
	git add README.rst
	git add index.html

