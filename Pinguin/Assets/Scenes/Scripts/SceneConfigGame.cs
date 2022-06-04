using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneConfigGame : SceneConfig
{
    public override Dictionary<Type, Interactor> CreateAllInteractors()
    {
        var interactorsMap = new Dictionary<Type, Interactor>();

        this.CreateInteractor<BankInteractor>(interactorsMap);
        
        return interactorsMap;
    }

    public override Dictionary<Type, Repository> CreateAllRepositories()
    {
        var repositoriesMap = new Dictionary<Type, Repository>();

        this.CreateRepository<BankRepository>(repositoriesMap);

        return repositoriesMap;
    }
}
