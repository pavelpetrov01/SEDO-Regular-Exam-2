pipeline {
    agent any
    stages {
		stage('Checkout repo'){
			steps{
			checkout scm
			}
		}
		
		stage('Restore project') { 
            steps {
                bat 'dotnet restore' 
            }
        }
        stage('Build') { 
            steps {
               
                bat 'dotnet build --no-restore' 
            }
        }
		    stage('Test') { 
            steps {
               
                bat 'dotnet test --no-restore --verbosity normal' 
            }
        }
    }
}
