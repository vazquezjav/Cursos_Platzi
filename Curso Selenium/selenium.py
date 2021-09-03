# -*- coding: utf-8 -*-
"""
Created on Sat Jul  3 08:40:06 2021

@author: vazqu
"""
import unittest
from pyunitreport import HTMLTestRunner
import selenium
from selenium import webdriver
class Pruebas(unittest.TestCase):
    
    def setUp(self):
        DRIVER_PATH = 'geckodriver.exe'
        self.driver = selenium.webdriver.Firefox(executable_path=DRIVER_PATH)
        driver=self.driver
        driver.implicitly_wait(10)

    def test_hello_world(self):
        driver = self.driver
        driver.get('https://www.platzi.com')
    
    def tearDown(self):
        self.driver.quit()
        return super().tearDown()

if __name__ == "__main__":
    unittest.main(verbosity=2,testRunner=HTMLTestRunner(output='reportes',report_name='hello-wolrd-report'))
        