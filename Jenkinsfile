pipeline {
  agent any
  stages {
    stage('Restore packages') {
      steps {
        bat(script: 'C:\\Users\\Alexey_Myalik\\Nuget\\nuget.exe restore C:\\Users\\Alexey_Myalik\\source\\repos\\MyTestProject\\MyTestProject.sln', returnStatus: true)
      }
    }

    stage('Build') {
      steps {
        bat(script: 'dotnet build C:\\Users\\Alexey_Myalik\\source\\repos\\MyTestProject\\MyTestProject -o C:\\Users\\Alexey_Myalik\\source\\repos\\MyTestProject\\MyTestProject\\UnitTests', returnStatus: true)
      }
    }

  }
}