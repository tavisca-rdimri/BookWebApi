pipeline {
    agent any
	
	parameters
	{
	string (

 
			name : 'solution',

 
			defaultValue: 'DemoApi.sln',

 
			description: 'Solution File'

 
            )

	}
	
    stages { 
        stage('Build') {
        	
        	steps{
        		echo '==================================Building======================================='
			}
        }
        stage('Sonarqube') {
			environment {
				scannerHome = tool 'SonarQubeScanner'
			}
		steps {
        withSonarQubeEnv('sonarqube') {
            sh "${scannerHome}/bin/sonar-scanner"
        }
        timeout(time: 10, unit: 'MINUTES') {
            waitForQualityGate abortPipeline: true
        }
		}
		}
        stage('Publish') {
        	
        	steps{
        		echo '====================================Publishing==================================='
        		}
        }
		
		}
		}
