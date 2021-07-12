import json
from logging import debug
from re import L
from threading import Thread
from time import strptime
from typing import Optional
import requests
from datetime import datetime, timedelta
import uvicorn
from fastapi import FastAPI
from fastapi.encoders import jsonable_encoder
from fastapi.responses import JSONResponse
from pydantic import BaseModel
from fastapi.middleware.cors import CORSMiddleware
from requests.api import request
from pymongo import MongoClient
from bson.objectid import ObjectId
from pprint import pprint
import hashlib
import pyodbc 
import sqlalchemy as sa
from sqlalchemy.ext.automap import automap_base
from sqlalchemy.orm import Session
from sqlalchemy import create_engine, Table
from sqlalchemy.ext.declarative import declarative_base

engine = create_engine('mssql+pyodbc://.\SQLEXPRESS/TSG?driver=SQL Server?Trusted_Connection=yes')

Base = declarative_base()

# reflect current database engine to metadata
metadata = sa.MetaData(engine)
metadata.reflect()
app = FastAPI()
origins = ["*"]
app.add_middleware(
    CORSMiddleware,
    allow_origins=origins,
    allow_credentials=True,
    allow_methods=["*"],
    allow_headers=["*"],
)
conn = pyodbc.connect('Driver={SQL Server};'
                        'Server=.\SQLEXPRESS;'
                        'Database=TSG;'
                        'Trusted_Connection=yes;')

class Personal_TSG(Base):
    __table__ = Table("Personal_TSG", metadata)


@app.get("/getPersonal")
def getPersonal():
    Session = sa.orm.sessionmaker(engine)
    session = Session()
    ds = session.query(Personal_TSG.ID, Personal_TSG.Nume, Personal_TSG.ID_Proiect).all()
    data = []
    for row in ds:
        data.append([field for field in row])
    return JSONResponse(status_code=200, content={'Personal_TSG':data})


@app.get("/getProiecte")
def getProiecte():   
    CURSOR = conn.cursor().execute('exec SelectProiecte_TSG')
    data = []
    for row in CURSOR:
        data.append([field for field in row])
    return JSONResponse(status_code=200, content={'Personal_TSG':data})

@app.get("/getPersonal_Proiecte")
def getPersonal_Proiecte():   
    CURSOR = conn.cursor().execute('exec SelectPersonal_Proiecte_TSG')
    data = []
    for row in CURSOR:
        data.append([field for field in row])
    return JSONResponse(status_code=200, content={'Personal_TSG':data})


@app.get("/getVenit_Personal")
def getVenit_Personal():   
    CURSOR = conn.cursor().execute('exec SelectVenit_Personal_TSG')
    data = []
    for row in CURSOR:
        data.append([field for field in row])
    return JSONResponse(status_code=200, content={'Personal_TSG':data})


@app.get("/getEchipe")
def getEchipe():   
    CURSOR = conn.cursor().execute('exec SelectEchipe_TSG')
    data = []
    for row in CURSOR:
        data.append([field for field in row])
    return JSONResponse(status_code=200, content={'Personal_TSG':data})


@app.get("/Join_One-One")
def getOne_One():   
    CURSOR = conn.cursor().execute('exec JoinOne_To_One')
    data = []
    for row in CURSOR:
        data.append([field for field in row])
    return JSONResponse(status_code=200, content={'Personal_TSG':data})
    
@app.get("/Join_One-Many")
def getOne_Many():   
    CURSOR = conn.cursor().execute('exec JoinOne_To_Many')
    data = []
    for row in CURSOR:
        data.append([field for field in row])
    return JSONResponse(status_code=200, content={'Personal_TSG':data})

@app.get("/Join_Many-Many")
def getMany_Many():   
    CURSOR = conn.cursor().execute('exec JoinMany_To_Many')
    data = []
    for row in CURSOR:
        data.append([field for field in row])
    return JSONResponse(status_code=200, content={'Personal_TSG':data})
    
@app.get("/getEchipe")
def getEchipe():   
    CURSOR = conn.cursor().execute('exec SelectEchipe_TSG')
    data = []
    for row in CURSOR:
        data.append([field for field in row])
    return JSONResponse(status_code=200, content={'Personal_TSG':data})


@app.post("/createPersonal")
def createPersonal(Nume : str, ID_Proiect : int):   
    Session = sa.orm.sessionmaker(engine)
    session = Session()
    newPersonal = Personal_TSG(Nume=Nume, ID_Proiect=ID_Proiect)
    session.add(newPersonal)
    session.commit()
    return JSONResponse(status_code=200, content={'Success': 'The user has been added'})

@app.post("/createProiect")
def createProiect(Proiect : str):   
    CURSOR = conn.cursor().execute('exec CreateProiecte_TSG @Proiect={}'.format(Proiect))
    conn.commit()
    return JSONResponse(status_code=200, content={'Success': 'The project has been added'})

@app.post("/createPersonal_Proiecte")
def createPersonal_Proiecte(ID_Personal : int, ID_Proiect : int):   
    CURSOR = conn.cursor().execute('exec CreatePersonal_Proiecte_TSG @ID_Personal={}, @ID_Proiect={}'.format(ID_Personal, ID_Proiect))
    conn.commit()
    return JSONResponse(status_code=200, content={'Success': 'The (person, project) has been added'})

@app.post("/createVenit_Personal")
def createVenit_Personal(ID_Personal : str, Venit : float):   
    CURSOR = conn.cursor().execute('exec CreateVenit_Personal_TSG @ID_Personal={}, @Venit={}'.format(ID_Personal, Venit))
    conn.commit()
    return JSONResponse(status_code=200, content={'Success': 'The (person, venit) has been added'})

@app.post("/createEchipa")
def createEchipa(ID_TeamLeader : int):   
    CURSOR = conn.cursor().execute('exec CreateEchipe_TSG @ID_TeamLeader={}'.format(ID_TeamLeader))
    conn.commit()
    return JSONResponse(status_code=200, content={'Success': 'The team has been added'})

@app.delete("/deletePersonal")
def deletePersonal(Nume : str):
    CURSOR = conn.cursor().execute('exec DeletePersonal_TSG @Nume={}'.format(Nume))
    conn.commit()
    return JSONResponse(status_code=200, content={'Success': 'The user has been deleted'})

@app.delete("/deleteProiect")
def deleteProiect(Proiect : str):
    CURSOR = conn.cursor().execute('exec DeleteProiecte_TSG @Proiect={}'.format(Proiect))
    conn.commit()
    return JSONResponse(status_code=200, content={'Success': 'The project has been deleted'})

@app.delete("/deletePersonal_Proiecte")
def deletePersonal_Proiecte(ID_Proiect : int):
    CURSOR = conn.cursor().execute('exec DeletePersonal_Proiecte_TSG @ID_Proiect={}'.format(ID_Proiect))
    conn.commit()
    return JSONResponse(status_code=200, content={'Success': 'The (person, project) has been deleted'})

@app.delete("/deleteVenit_Personal")
def deleteVenit_Personal(ID_Personal : int):
    CURSOR = conn.cursor().execute('exec DeleteVenit_Personal_TSG @ID_Personal={}'.format(ID_Personal))
    conn.commit()
    return JSONResponse(status_code=200, content={'Success': 'The (person, venit) has been deleted'})

@app.delete("/deleteEchipa")
def deleteEchipa(ID_Echipa : str):
    CURSOR = conn.cursor().execute('exec DeleteEchipe_TSG @ID_Echipa={}'.format(ID_Echipa))
    conn.commit()
    return JSONResponse(status_code=200, content={'Success': 'The team has been deleted'})

@app.patch("/updatePersonal")
def updatePersonal(ID_Proiect : int, Nume : str):
    CURSOR = conn.cursor().execute('exec UpdatePersonal_TSG @ID_Proiect={}, @Nume={}'.format(ID_Proiect, Nume))
    conn.commit()
    return JSONResponse(status_code=200, content={'Success': 'The user has been updated'})

@app.patch("/updateProiecte")
def updateProiecte(NouProiect : str, Proiect : str):
    CURSOR = conn.cursor().execute('exec UpdateProiecte_TSG @NouProiect={}, @Proiect={}'.format(NouProiect, Proiect))
    conn.commit()
    return JSONResponse(status_code=200, content={'Success': 'The project has been updated'})

@app.patch("/updatePersonal_Proiecte")
def updatePersonal_Proiecte(ID_Personal : int, ID_Proiect : int):
    CURSOR = conn.cursor().execute('exec UpdatePersonal_Proiecte_TSG @ID_Personal={}, @ID_Proiect={}'.format(ID_Personal, ID_Proiect))
    conn.commit()
    return JSONResponse(status_code=200, content={'Success': 'The (person, project) has been updated'})

@app.patch("/updateUpdateVenit_Personal")
def updateUpdateVenit_Personal(ID_Personal : int, Venit : float):
    CURSOR = conn.cursor().execute('exec UpdateVenit_Personal_TSG @ID_Personal={}, @Venit={}'.format(ID_Personal, Venit))
    conn.commit()
    return JSONResponse(status_code=200, content={'Success': 'The (person, venit) has been updated'})

@app.patch("/updateEchipa")
def updateEchipa(ID_Echipa : int, ID_TeamLeader : str):
    CURSOR = conn.cursor().execute('exec UpdateEchipe_TSG @ID_Echipa={}, @ID_TeamLeader={}'.format(ID_Echipa, ID_TeamLeader))
    conn.commit()
    return JSONResponse(status_code=200, content={'Success': 'The team has been updated'})


if __name__ == "__main__":
    uvicorn.run(app, host="127.0.0.1", port=8000, debug=True)
